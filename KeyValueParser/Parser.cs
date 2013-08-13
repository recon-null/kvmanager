#region Program Header

// THE BELOW HEADER MUST NOT BE REMOVED OR MODIFIED
//
// This file is part of KeyValueParser.
//
// KeyValueParser is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// KeyValueParser is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with KeyValueParser.  If not, see <http://www.gnu.org/licenses/>.
//
// THE ABOVE HEADER MUST NOT BE REMOVED OR MODIFIED

#endregion

#region Using

// Default using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

#endregion

namespace KeyValueParser
{
    /// <summary>
    /// Parser class for key value files
    /// </summary>
    public static class KVParser
    {
        /// <summary>
        /// Used to search for the end of keys
        /// </summary>
        private static readonly char[] KV_SEARCH = { '\t', ' ' };

        #region WriteToFile

        /// <summary>
        /// Writes <paramref name="kvs"/> to
        /// <paramref name="filePath"/>
        /// </summary>
        /// <param name="kvs">
        /// The KVs to write
        /// </param>
        /// <param name="filePath">
        /// Path to the file to write to
        /// </param>
        public static void WriteToFile(KVItem kvs, string filePath)
        {
            // Holds the lines
            List<string> lines = new List<string>();
            
            // Get the lines
            Write(kvs, lines, 0);

            // Write the lines
            File.WriteAllLines(filePath, lines.ToArray());
        }

        #endregion

        #region Write

        /// <summary>
        /// Writes KVs to a file
        /// </summary>
        /// <param name="kvs">
        /// The KVs to write
        /// </param>
        /// <param name="lines">
        /// The lines collection
        /// </param>
        /// <param name="numOfTabs">
        /// The number of tabs to use
        /// </param>
        public static void Write(KVItem kvs, List<string> lines, int numOfTabs)
        {
            // Is this a section?
            if (kvs.isSection())
            {
                // Add and open the section
                lines.Add(GetTabs(numOfTabs) + "\"" + kvs.key + "\"");
                lines.Add(GetTabs(numOfTabs) + "{");                
            }            

            // Add sub items
            foreach (KVItem item in kvs.subItems)
            {
                // Add the item if it isn't a section
                if (!item.isSection())
                    lines.Add(GetTabs(numOfTabs + 1) +
                              "\"" + item.key + "\"" + GetTabs(2) +
                              "\"" + item.value + "\"");

                // If there are sub items,
                // add them
                if (item.subItems.Count > 0)
                {
                    numOfTabs++;
                    Write(item, lines, numOfTabs);
                    numOfTabs--;
                }
            }

            // Close the section
            lines.Add(GetTabs(numOfTabs) + "}");
        }

        #endregion

        #region GetTabs

        /// <summary>
        /// Returns <paramref name="numOfTabs"/> tabs
        /// </summary>
        /// <param name="numOfTabs">
        /// The number of tabs to return
        /// </param>
        /// <returns>
        /// The tabs
        /// </returns>
        private static string GetTabs(int numOfTabs)
        {
            // Holds the tabs            
            StringBuilder tabs = new StringBuilder(numOfTabs);

            // Create the tabs
            for (int i = 0; i < numOfTabs; i++)
                tabs.Append('\t');

            // Return the tabs
            return tabs.ToString();
        }

        #endregion

        #region ReadFromFile

        /// <summary>
        /// Reads a KV file from a file
        /// </summary>
        /// <param name="filePath">
        /// The path to the file
        /// </param>
        /// <returns>
        /// The parsed KVs
        /// </returns>
        public static KVItem ReadFromFile(string filePath)
        {
            // The key values
            KVItem items = new KVItem();
            
            // Read the file
            string[] lines = File.ReadAllLines(filePath);
            
            // Holds the starting index
            int i = 0;

            // Parse the file
            Read(lines, ref i, items);

            // Return the items
            if (items.subItems.Count > 0)
                return items.subItems[0];
            else
                return null;
        }

        #endregion

        #region Read

        /// <summary>
        /// Reads a KV file recursively
        /// </summary>
        /// <param name="lines">
        /// The lines from the KV file
        /// </param>
        /// <param name="index">
        /// The line to start reading at
        /// </param>
        /// <param name="kvs">
        /// The parsed key values
        /// </param>
        private static void Read(string[] lines, ref int index, KVItem kvs)
        {
            // Stores if we are in a multi line comment
            bool multiLC = false;

            // Read the lines
            while (index < lines.Length)
            {
                string cl = lines[index].Trim();

                // Increment the counter
                index++;

                // ******* BEGIN: Check for lines to ignore

                // At the end of a multi line comment
                if (multiLC && cl.StartsWith("*/"))
                {
                    multiLC = false;
                }

                // In the middle of a multi line comment,
                // found a single line comment,
                // or if the line is blank
                else if (multiLC || cl.StartsWith("//")
                         || cl.Trim().Length == 0)
                {
                    // Nothing to do, skip to the next line
                    continue;
                }

                // Beginning a multiline comment
                else if (cl.StartsWith("/*"))
                {
                    multiLC = true;
                }

                // ******* END: Check for lines to ignore          

                // Real line
                else
                {
                    // Check for in line comments
                    if (cl.Contains("//"))
                    {
                        // Get the index where the comment starts
                        int loc = cl.IndexOf("//");

                        // Remove the comment
                        cl = cl.Remove(loc, cl.Length - loc);
                    }

                    // Check to see if we have a space,
                    // spaces and a brace, or just a brace,
                    // and if any of those are true, skip the line
                    Regex spacesAndOrBrace = new Regex(@"^\s*{$");
                    if (spacesAndOrBrace.IsMatch(cl))
                        continue;

                    // End of the section, return
                    if (cl.Contains("}"))
                        return;

                    // Read the line as a kv pair
                    KVItem item = new KVItem();
                    int keyStart = -1, keyEnd = -1,
                        valueStart = -1, valueEnd = -1;

                    // Trim whitespace
                    cl = cl.Trim();

                    // Locate the start and end
                    // of the key and value
                    keyStart = 0;
                    keyEnd = cl.IndexOf("\"", keyStart + 1);

                    // Is this key quoted?
                    if (keyEnd == -1)
                    {
                        // No quote, use space / tab to search
                        // for the end
                        keyEnd = cl.IndexOfAny(KV_SEARCH, keyStart + 1);

                        // Key is the rest of the line
                        if (keyEnd == -1)
                            keyEnd = cl.Length - 1;
                    }

                    // Find the value
                    valueStart = cl.IndexOfAny(KV_SEARCH, keyEnd + 1);
                    valueEnd = cl.Length - 1;

                    // Check for a section with the name and opening brace
                    // on the same line
                    Regex sectionAndBrace = new Regex("^.+{.*$");

                    // Get the key
                    string key = CleanString(cl.Substring(keyStart, keyEnd - keyStart + 1));

                    // If there is no value, this is a section
                    if (valueStart == -1 || valueEnd == -1 || sectionAndBrace.IsMatch(cl))
                    {
                        // Save the key and add the section
                        item.key = key;
                        kvs.subItems.Add(item);

                        // Recursively parse the sub section
                        Read(lines, ref index, item);
                    }

                    // This is a KV pair
                    else
                    {
                        // Set the key and value and add the item
                        item.key = key;
                        item.value = CleanString(cl.Substring(valueStart, valueEnd - valueStart + 1));
                        kvs.subItems.Add(item);
                    }
                }

            } // End line reading loop            

        } // End method

        #endregion

        #region CleanString

        /// <summary>
        /// Cleans <paramref name="s"/> 
        /// (strips double quotes and trims)
        /// </summary>
        /// <param name="s">
        /// The string to clean
        /// </param>
        /// <returns>
        /// <paramref name="s"/> cleaned
        /// </returns>
        private static string CleanString(string s)
        {
            return s.Replace("\"", "").Trim();
        }

        #endregion
    }        
}