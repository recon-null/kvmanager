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

// For use of the CheckBox class
using System.Windows.Forms;

#endregion

namespace KVManager
{
    /// <summary>
    /// CheckBox class with a constructor
    /// with a text parameter
    /// </summary>
    public class SmartCheckBox : CheckBox
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="text">
        /// The text to be displayed on
        /// the check box
        /// </param>
        public SmartCheckBox(string text)
            : base()
        {
            // Set auto size
            base.AutoSize = true;

            // Set the text
            base.Text = text;            
        }
    }
}