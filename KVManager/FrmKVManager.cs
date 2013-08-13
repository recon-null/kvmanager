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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For use of our KV parser
using KVParser = KeyValueParser.KVParser;
using KVItem = KeyValueParser.KVItem;

#endregion

namespace KVManager
{
    /// <summary>
    /// KV manager main form
    /// </summary>
    public partial class FrmKVManager : Form
    {
        #region Private Objects
               
        /// <summary>
        /// The about box
        /// </summary>
        private FrmAboutBox aboutBox = null;

        /// <summary>
        /// Admin filter
        /// </summary>
        private const string FILTER_ADMIN = "Admin Configs|admins.cfg";

        /// <summary>
        /// Group filter
        /// </summary>
        private const string FILTER_GROUP = "Group Configs|admin_groups.cfg";

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmKVManager()
        {
            InitializeComponent();

            // Create the about box
            aboutBox = new FrmAboutBox();

            // Style the grids
            StyleGrid(dgvAdminList);
            StyleGrid(dgvGroupList);

            // Set the filter on the open file dialog
            ofdMain.Filter = FILTER_ADMIN + "|" + FILTER_GROUP;

            // Setup the default state for the form
            AdminPositionChanged();
            GroupPositionChanged();

            // Set up the file dialogs
            ofdMain.InitialDirectory = sfdMain.InitialDirectory
                = Application.StartupPath;
        }

        #endregion

        #region tcMain SelectedIndexChanged Event

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the filter based on the current tab page
            ofdMain.FilterIndex = tcMain.SelectedIndex + 1;

            if (tcMain.SelectedTab == tpAdmin)
            {
                AdminPositionChanged();
            }
            else
            {
                GroupPositionChanged();
            }
        }       

        #endregion

        #region openToolStripMenuItem Click Event

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompt the user to pick an input file
            if (ofdMain.ShowDialog() == DialogResult.OK)
            {
                // admins.cfg
                if (ofdMain.FilterIndex == 1)
                {
                    try
                    {
                        // Load the admins
                        KVItem admins = KVParser.ReadFromFile(ofdMain.FileName);

                        // If we loaded admins into the KVs,
                        // load them into the dataset
                        if (admins != null)
                            LoadAdminsToDS(admins, _dsAdmins);

                        // Select the admins tab
                        tcMain.SelectedTab = tpAdmin;
                    }                   

                    catch (Exception ex)
                    {
                        // Let the user know something went wrong
                        ErrorHandler.ShowError(ex);
                    }
                }

                // admin_groups.cfg
                else if (ofdMain.FilterIndex == 2)
                {
                    // Load the groups
                    KVItem groups = KVParser.ReadFromFile(ofdMain.FileName);

                    // If we loaded groups into the KVs,
                    // load them into the dataset
                    if (groups != null)
                        LoadGroupsToDS(groups, _dsGroups);

                    // Select the groups tab
                    tcMain.SelectedTab = tpGroup;
                }
            }
        }

        #endregion

        #region saveToolStripMenuItem Click Event

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the filter
            if (tcMain.SelectedTab == tpAdmin)
                sfdMain.Filter = FILTER_ADMIN;
            else
                sfdMain.Filter = FILTER_GROUP;

            // Prompt the user to save the file
            if (sfdMain.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // admins.cfg
                    if (sfdMain.Filter == FILTER_ADMIN)
                    {
                        // Create the root section
                        KVItem admins = new KVItem();
                        admins.key = "Admins";

                        foreach (dsAdmins.dtAdminsRow row in _dsAdmins.dtAdmins)
                        {
                            // Create the admin
                            KVItem currentAdmin = new KVItem(row.name, null);

                            // Set the the auth and identity
                            currentAdmin.subItems.Add(new KVItem("auth", row.authType));
                            currentAdmin.subItems.Add(new KVItem("identity", row.identity));

                            // Make sure group isn't empty before creating the KV pair
                            if (row.group != null && row.group.Trim() != "")
                                currentAdmin.subItems.Add(new KVItem("group", row.group));

                            // Set the immunity and flags
                            currentAdmin.subItems.Add(new KVItem("immunity",
                                                          ((int)row.immunity).ToString()));
                            currentAdmin.subItems.Add(new KVItem("flags", row.flags));

                            // Add the admin
                            admins.subItems.Add(currentAdmin);
                        }

                        // Save the file
                        KVParser.WriteToFile(admins, sfdMain.FileName);
                    }

                    // admin_groups.cfg
                    else if (sfdMain.Filter == FILTER_GROUP)
                    {
                        // Create the root section
                        KVItem groups = new KVItem();
                        groups.key = "Groups";

                        // Add all the groups
                        foreach (dsGroups.dtGroupsRow groupRow in _dsGroups.dtGroups)
                        {
                            KVItem currentGroup = new KVItem();
                            currentGroup.key = groupRow.name;

                            // Set the KVs
                            currentGroup.subItems.Add
                                (new KVItem("flags", groupRow.flags));
                            currentGroup.subItems.Add
                                (new KVItem("immunity", ((int)groupRow.immunity).ToString()));

                            // Get the override rows
                            DataRow[] overrides = groupRow.GetChildRows(_dsGroups.Relations[0]);

                            // Does this group have overrides?
                            if (overrides.Length > 0)
                            {
                                // Yes, add the overrides section
                                KVItem ovrSection = new KVItem();
                                ovrSection.key = "Overrides";

                                // Add each override
                                foreach (DataRow row in overrides)
                                {
                                    // Get a typed version of the row
                                    dsGroups.dtOverridesRow ovrRow = (dsGroups.dtOverridesRow)row;

                                    // Create the KV pair
                                    ovrSection.subItems.Add(new KVItem(ovrRow.key, ovrRow.value));
                                }

                                // Add the override section
                                currentGroup.subItems.Add(ovrSection);
                            }

                            // Add the group
                            groups.subItems.Add(currentGroup);
                        }

                        // Save the file
                        KVParser.WriteToFile(groups, sfdMain.FileName);
                    }
                }

                catch (StrongTypingException ex)
                {
                    if (ex.Message.Contains("name"))
                        MessageBox.Show("You must enter a name.",
                                        "Missing Name", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                    else if (ex.Message.Contains("identity"))
                        MessageBox.Show("You must enter an identity.", 
                                        "Missing Identity", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                    else if (ex.Message.Contains("key"))
                        MessageBox.Show("You must enter a command / command group.",
                                     "Missing Command / Command Group",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);

                }

                catch (Exception ex)
                {
                    // Let the user know something went wrong
                    ErrorHandler.ShowError(ex);
                }
            }
        }

        #endregion

        #region exitToolStripMenuItem Click Event

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        #endregion

        #region aboutToolStripMenuItem Click Event

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the about box
            aboutBox.ShowDialog(this);
        }

        #endregion        
        
        #region bsAdmins PositionChanged Event

        private void bsAdmins_PositionChanged(object sender, EventArgs e)
        {
            // Call the admin position changed method
            AdminPositionChanged();
        }

        #endregion

        #region bsGroups PositionChanged Event

        private void bsGroups_PositionChanged(object sender, EventArgs e)
        {
            // Call the group position changed method
            GroupPositionChanged();
        }

        #endregion

        #region tsbAdd Click Event

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            // Create a new admin
            if (tcMain.SelectedTab == tpAdmin)
            {
                // Create the row
                dsAdmins.dtAdminsRow row = _dsAdmins.dtAdmins.NewdtAdminsRow();

                // Set the name
                row.name = "New Admin";

                // Add the row
                _dsAdmins.dtAdmins.AdddtAdminsRow(row);
            }
            else if (tcMain.SelectedTab == tpGroup)
            {
                // Create the row
                dsGroups.dtGroupsRow row = _dsGroups.dtGroups.NewdtGroupsRow();

                // Set the name
                row.name = "New Group";

                // Add the row
                _dsGroups.dtGroups.AdddtGroupsRow(row);
            }
        }

        #endregion

        #region tsbDelete Click Event

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            // What are we deleting?
            if (tcMain.SelectedTab == tpAdmin)
            {
                // Make sure something is selected
                if (bsAdmins.Position > -1)
                    _dsAdmins.dtAdmins[bsAdmins.Position].Delete();
            }
            else if (tcMain.SelectedTab == tpGroup)
            {
                // Make sure something is selected
                if (bsGroups.Position > -1)
                    _dsGroups.dtGroups[bsGroups.IndexOf(bsGroups.Current)].Delete();
            }
        }

        #endregion        

        #region AdminPositionChanged

        /// <summary>
        /// Called when the admin position changes
        /// </summary>
        private void AdminPositionChanged()
        {
            // Set contexts
            tsbDelete.Enabled = grpAdminDetails.Enabled =
                acAdminFlags.Enabled = (bsAdmins.Position > -1);
        }

        #endregion

        #region GroupPositionChanged

        /// <summary>
        /// Called when the group position changes
        /// </summary>
        private void GroupPositionChanged()
        {
            // Set contexts
            tsbDelete.Enabled = numGroupImmunity.Enabled =
                acGroupFlags.Enabled = grpOverrides.Enabled =
                (bsGroups.Position > -1);
        }

        #endregion

        #region LoadGroupsToDS

        private void LoadGroupsToDS(KVItem groups, dsGroups ds)
        {
            if (groups.key == "Groups")
            {
                foreach (KVItem grp in groups.subItems)
                {
                    // Create the groups row
                    dsGroups.dtGroupsRow groupRow =
                        _dsGroups.dtGroups.NewdtGroupsRow();

                    // Set the name
                    groupRow.name = grp.key;

                    // Add the group row
                    ds.dtGroups.AdddtGroupsRow(groupRow);

                    // Get the kv pairs
                    foreach (KVItem subitem in grp.subItems)
                    {
                        // What key is this?
                        switch (subitem.key.ToLower())
                        {
                            case "flags":
                                groupRow.flags = subitem.value.ToLower();
                                break;

                            case "immunity":
                                groupRow.immunity = Decimal.Parse(subitem.value);
                                break;

                            case "overrides":
                                foreach (KVItem ovr in subitem.subItems)
                                {
                                    // Create the override row and attach it to
                                    // the group row
                                    dsGroups.dtOverridesRow ovrRow =
                                        _dsGroups.dtOverrides.NewdtOverridesRow();
                                    ovrRow.dtGroupsRow = groupRow;

                                    // Save the key and value
                                    ovrRow.key = ovr.key;
                                    ovrRow.value = ovr.value.ToLower();

                                    // Add the row
                                    ds.dtOverrides.AdddtOverridesRow(ovrRow);
                                }
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                // User tried to load an invalid group file
                MessageBox.Show("Invalid admin_groups.cfg.", "Invalid File",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region LoadAdminsToDS

        /// <summary>
        /// Loads admins into a DS
        ///</summary>
        /// <param name="admins">
        /// The admin KVs to load from
        /// </param>
        /// <param name="ds">
        /// The dataset to load to
        /// </param>
        private void LoadAdminsToDS(KVItem admins, dsAdmins ds)
        {
            // Make sure the root section is admins
            if (admins.key == "Admins")
            {
                // Create admin rows for each admin
                foreach (KVItem adm in admins.subItems)
                {
                    // Create the row
                    dsAdmins.dtAdminsRow row = ds.dtAdmins.NewdtAdminsRow();

                    // Set the name
                    row.name = adm.key;

                    foreach (KVItem item in adm.subItems)
                    {
                        // Find where this value is supposed
                        // to go
                        switch (item.key.ToLower())
                        {
                            case "auth":
                                row.authType = item.value.ToLower();
                                break;

                            case "identity":
                                row.identity = item.value;
                                break;

                            case "group":
                                row.group = item.value;
                                break;

                            case "immunity":
                                row.immunity = Decimal.Parse(item.value);
                                break;

                            case "flags":
                                row.flags = item.value.ToLower();
                                break;

                            default:
                                break;
                        }
                    }

                    // Add the row
                    ds.dtAdmins.AdddtAdminsRow(row);
                }
            }
            else
            {
                // User tried to load an invalid admin file
                MessageBox.Show("Invalid admins.cfg.", "Invalid File",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion                                

        #region StyleGrid

        /// <summary>
        /// Styles a DataGridView
        /// </summary>
        /// <param name="dgv">
        /// The DataGridView to style
        /// </param>
        private void StyleGrid(DataGridView dgv)
        {
            // Set the style
            dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.Maroon;
        }

        #endregion        
    }
}