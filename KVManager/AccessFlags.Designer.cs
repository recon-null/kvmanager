namespace KVManager
{
    partial class AccessFlags
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAccessFlags = new System.Windows.Forms.GroupBox();
            this.tlpFlags = new System.Windows.Forms.TableLayoutPanel();
            this.grpAccessFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccessFlags
            // 
            this.grpAccessFlags.Controls.Add(this.tlpFlags);
            this.grpAccessFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAccessFlags.Location = new System.Drawing.Point(0, 0);
            this.grpAccessFlags.Name = "grpAccessFlags";
            this.grpAccessFlags.Size = new System.Drawing.Size(268, 214);
            this.grpAccessFlags.TabIndex = 11;
            this.grpAccessFlags.TabStop = false;
            this.grpAccessFlags.Text = "Access Flags:";
            // 
            // tlpFlags
            // 
            this.tlpFlags.ColumnCount = 2;
            this.tlpFlags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFlags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFlags.Location = new System.Drawing.Point(3, 16);
            this.tlpFlags.Name = "tlpFlags";
            this.tlpFlags.RowCount = 1;
            this.tlpFlags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFlags.Size = new System.Drawing.Size(262, 195);
            this.tlpFlags.TabIndex = 0;
            // 
            // AccessFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpAccessFlags);
            this.Name = "AccessFlags";
            this.Size = new System.Drawing.Size(268, 214);
            this.grpAccessFlags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccessFlags;
        private System.Windows.Forms.TableLayoutPanel tlpFlags;
    }
}
