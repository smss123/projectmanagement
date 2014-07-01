namespace ProjectManament.usergroup
{
    partial class frmUserGroup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label groupNameLabel;
            System.Windows.Forms.Label groupDescriptionLabel;
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.groupNameRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.groupDescriptionRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            iDLabel = new System.Windows.Forms.Label();
            groupNameLabel = new System.Windows.Forms.Label();
            groupDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupNameRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDescriptionRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(629, 56);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 13;
            iDLabel.Text = "ID:";
            // 
            // groupNameLabel
            // 
            groupNameLabel.AutoSize = true;
            groupNameLabel.Location = new System.Drawing.Point(629, 81);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(75, 13);
            groupNameLabel.TabIndex = 11;
            groupNameLabel.Text = "Group Name:";
            // 
            // groupDescriptionLabel
            // 
            groupDescriptionLabel.AutoSize = true;
            groupDescriptionLabel.Location = new System.Drawing.Point(629, 105);
            groupDescriptionLabel.Name = "groupDescriptionLabel";
            groupDescriptionLabel.Size = new System.Drawing.Size(105, 13);
            groupDescriptionLabel.TabIndex = 9;
            groupDescriptionLabel.Text = "Group Description:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(404, 53);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(219, 20);
            this.iDTextBox.TabIndex = 14;
            // 
            // groupNameRadTextBox
            // 
            this.groupNameRadTextBox.Location = new System.Drawing.Point(404, 79);
            this.groupNameRadTextBox.Name = "groupNameRadTextBox";
            this.groupNameRadTextBox.Size = new System.Drawing.Size(219, 20);
            this.groupNameRadTextBox.TabIndex = 12;
            // 
            // groupDescriptionRadTextBox
            // 
            this.groupDescriptionRadTextBox.AutoSize = false;
            this.groupDescriptionRadTextBox.Location = new System.Drawing.Point(404, 105);
            this.groupDescriptionRadTextBox.Multiline = true;
            this.groupDescriptionRadTextBox.Name = "groupDescriptionRadTextBox";
            this.groupDescriptionRadTextBox.Size = new System.Drawing.Size(219, 72);
            this.groupDescriptionRadTextBox.TabIndex = 10;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(32, 53);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(196, 123);
            this.checkedListBox1.TabIndex = 15;
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(32, 259);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "الرقم";
            gridViewTextBoxColumn1.Name = "ColID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "اسم المجموعة";
            gridViewTextBoxColumn2.Name = "colGroupName";
            gridViewTextBoxColumn2.Width = 167;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "وصف المجموعة";
            gridViewTextBoxColumn3.Name = "colDescription";
            gridViewTextBoxColumn3.Width = 259;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(672, 150);
            this.radGridView1.TabIndex = 16;
            this.radGridView1.Text = "radGridView1";
            // 
            // frmUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 491);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(groupNameLabel);
            this.Controls.Add(this.groupNameRadTextBox);
            this.Controls.Add(groupDescriptionLabel);
            this.Controls.Add(this.groupDescriptionRadTextBox);
            this.Name = "frmUserGroup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmUserGroup";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmUserGroupLoad);
            ((System.ComponentModel.ISupportInitialize)(this.groupNameRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDescriptionRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iDTextBox;
        private Telerik.WinControls.UI.RadTextBox groupNameRadTextBox;
        private Telerik.WinControls.UI.RadTextBox groupDescriptionRadTextBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
