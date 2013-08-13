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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#endregion

namespace KVManager
{
    public partial class AccessFlags : UserControl
    {
        #region Private Objects

        /// <summary>
        /// Private object for the FlagString property
        /// </summary>
        private string flagString = "";

        /// <summary>
        /// The access flag controls
        /// </summary>
        private Dictionary<string, SmartCheckBox> flags
            = null;

        #endregion

        #region Property FlagString

        /// <summary>
        /// Gets or sets the flag string repersented by
        /// this control
        /// </summary>
        [Bindable(BindableSupport.Yes)]
        public string FlagString
        {
            get
            {
                return flagString;
            }
            set
            {
                flagString = value;
                FlagManager.SetByFlagString(flags, flagString);
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public AccessFlags()
        {
            InitializeComponent();

            // Get the flag dictionary
            flags = FlagManager.GetAccessFlagDict();

            // Attach the checkboxes to the check changed event
            foreach (SmartCheckBox chk in flags.Values)            
                chk.CheckedChanged += new EventHandler(chk_CheckedChanged);            

            // Add all the rows
            for (int i = 0; i < flags.Count; i++)            
                tlpFlags.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Add the first column of controls
            for (int i = 0; i < flags.Count - 10; i++)            
                tlpFlags.Controls.Add(flags.Values.ElementAt(i), 0, i);

            // Add the second column of controls
            for (int i = 10; i < flags.Count; i++)                            
                tlpFlags.Controls.Add(flags.Values.ElementAt(i), 1, i - 10);           
        }

        #endregion

        #region chk CheckedChanged Event

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            // Set the new flag string
            flagString = FlagManager.GetFlagString(flags);
        }

        #endregion
    }
}