#region Program Header

// THE BELOW HEADER MUST NOT BE REMOVED OR MODIFIED
//
// This file is part of KVManager.
//
// KVManager is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// KVManager is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with KVManager.  If not, see <http://www.gnu.org/licenses/>.
//
// THE ABOVE HEADER MUST NOT BE REMOVED OR MODIFIED

#endregion

#region Using

// Default using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// For use of our custom checkbox
using SCB = KVManager.SmartCheckBox;

#endregion

namespace KVManager
{
    /// <summary>
    /// Flag manager class
    /// </summary>
    public static class FlagManager
    {
        #region GetAccessFlagDict

        /// <summary>
        /// Gets a dictionary containing
        /// the flags and their checkboxes
        /// </summary>
        /// <returns>
        /// The dictionary of flags and checkboxes
        /// </returns>
        public static Dictionary<string, SmartCheckBox> GetAccessFlagDict()
        {
            // Holds the access flags
            Dictionary<string, SmartCheckBox> flags
                = new Dictionary<string, SmartCheckBox>();

            // Add the flags
            flags.Add("a", new SCB("Reserved slot"));
            flags.Add("b", new SCB("Generic admin"));
            flags.Add("c", new SCB("Kick players"));
            flags.Add("d", new SCB("Ban players"));
            flags.Add("e", new SCB("Unban players"));
            flags.Add("f", new SCB("Slay / harm players"));
            flags.Add("g", new SCB("Change map"));
            flags.Add("h", new SCB("Change most cvars"));
            flags.Add("i", new SCB("Execute config files"));
            flags.Add("j", new SCB("Special chat privileges"));
            flags.Add("k", new SCB("Start or create votes"));
            flags.Add("l", new SCB("Change server password"));
            flags.Add("m", new SCB("Execute RCON commands"));
            flags.Add("n", new SCB("Turn cheats on and off"));
            flags.Add("z", new SCB("Root access (user has all flags)"));
            flags.Add("o", new SCB("Custom flag \"o\""));
            flags.Add("p", new SCB("Custom flag \"p\""));
            flags.Add("q", new SCB("Custom flag \"q\""));
            flags.Add("r", new SCB("Custom flag \"r\""));
            flags.Add("s", new SCB("Custom flag \"s\""));
            flags.Add("t", new SCB("Custom flag \"t\""));            

            // Return the flags
            return flags;
        }

        #endregion

        #region SetByFlagString

        /// <summary>
        /// Sets all the checkboxes to reflect
        /// <paramref name="strFlags"/>
        /// </summary>
        /// <param name="flags">
        /// The checkbox / flag dictionary to work with
        /// </param>
        /// <param name="strFlags">
        /// The flag string
        /// </param>
        public static void SetByFlagString(Dictionary<string, SmartCheckBox> flags,
                                           string strFlags)
        {
            // Reset all flags
            ResetFlags(flags);                       

            // Holds the flags
            List<string> flagList = new List<string>();

            // Get each flag
            for (int i = 0; i < strFlags.Length; i++)            
                flagList.Add(strFlags[i].ToString());            

            // Set any flags the user has
            foreach (string currentFlag in flagList)            
                flags[currentFlag].Checked = true;            
        }

        #endregion

        #region GetFlagString

        /// <summary>
        /// Gets the flag string version from
        /// a set of controls and keys
        /// </summary>
        /// <param name="flags">
        /// The control / key set to get the flags from
        /// </param>
        /// <returns>
        /// The flag string
        /// </returns>
        public static string GetFlagString(Dictionary<string, SmartCheckBox> flags)
        {
            // Holds the flag string
            string strFlags = "";

            // The list of flags
            string[] flagList = flags.Keys.ToArray();

            // Loop through all the flags
            for (int i = 0; i < flags.Count; i++)
            {
                // Get the checkbox
                SmartCheckBox chk = flags[flagList[i]];

                // Add the flag to the string
                strFlags += chk.Checked ? flagList[i] : "";
            }

            // Return the flag string
            return strFlags;
        }

        #endregion

        #region ResetFlags

        /// <summary>
        /// Unchecks all checkboxes in 
        /// <paramref name="flags"/>'s values
        /// </summary>
        /// <param name="flags">
        /// The checkboxes to reset
        /// </param>
        public static void ResetFlags(Dictionary<string, SmartCheckBox> flags)
        {
            // Reset all flags
            foreach (SmartCheckBox chk in flags.Values)
                chk.Checked = false;
        }       

        #endregion
    }
}