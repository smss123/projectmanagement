namespace ProjectManagment.Forms.UserGroup
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label groupDescriptionLabel;
            System.Windows.Forms.Label groupNameLabel;
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupDescriptionRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.groupNameRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radContextMenu1 = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            groupDescriptionLabel = new System.Windows.Forms.Label();
            groupNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupDescriptionRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNameRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDescriptionLabel
            // 
            groupDescriptionLabel.AutoSize = true;
            groupDescriptionLabel.Location = new System.Drawing.Point(250, 66);
            groupDescriptionLabel.Name = "groupDescriptionLabel";
            groupDescriptionLabel.Size = new System.Drawing.Size(105, 13);
            groupDescriptionLabel.TabIndex = 9;
            groupDescriptionLabel.Text = "Group Description:";
            // 
            // groupDescriptionRadTextBox
            // 
            this.groupDescriptionRadTextBox.AutoSize = false;
            this.groupDescriptionRadTextBox.Location = new System.Drawing.Point(59, 63);
            this.groupDescriptionRadTextBox.Multiline = true;
            this.groupDescriptionRadTextBox.Name = "groupDescriptionRadTextBox";
            this.groupDescriptionRadTextBox.Size = new System.Drawing.Size(188, 63);
            this.groupDescriptionRadTextBox.TabIndex = 10;
            // 
            // groupNameLabel
            // 
            groupNameLabel.AutoSize = true;
            groupNameLabel.Location = new System.Drawing.Point(250, 40);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(75, 13);
            groupNameLabel.TabIndex = 11;
            groupNameLabel.Text = "Group Name:";
            // 
            // groupNameRadTextBox
            // 
            this.groupNameRadTextBox.Location = new System.Drawing.Point(59, 37);
            this.groupNameRadTextBox.Name = "groupNameRadTextBox";
            this.groupNameRadTextBox.Size = new System.Drawing.Size(188, 20);
            this.groupNameRadTextBox.TabIndex = 12;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(groupDescriptionLabel);
            this.radGroupBox1.Controls.Add(this.groupDescriptionRadTextBox);
            this.radGroupBox1.Controls.Add(groupNameLabel);
            this.radGroupBox1.Controls.Add(this.groupNameRadTextBox);
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(519, 26);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(363, 145);
            this.radGroupBox1.TabIndex = 13;
            this.radGroupBox1.Text = "radGroupBox1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(101, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(217, 140);
            this.checkedListBox1.TabIndex = 14;
            // 
            // radContextMenu1
            // 
            this.radContextMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "حفظ         ctrl+s";
            this.radMenuItem1.AccessibleName = "btnSave";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "حفظ         ctrl+s";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "radMenuItem2";
            this.radMenuItem2.AccessibleName = "radMenuItem2";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "radMenuItem2";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "radMenuItem3";
            this.radMenuItem3.AccessibleName = "radMenuItem3";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "radMenuItem3";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(101, 212);
            // 
            // radGridView1
            // 
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "رقم المجموعة";
            gridViewTextBoxColumn1.Name = "colID";
            gridViewTextBoxColumn1.Width = 73;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "اسم المجموعة";
            gridViewTextBoxColumn2.Name = "colName";
            gridViewTextBoxColumn2.Width = 195;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "وصف المجموعة";
            gridViewTextBoxColumn3.Name = "colDescription";
            gridViewTextBoxColumn3.Width = 333;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(781, 150);
            this.radGridView1.TabIndex = 15;
            this.radGridView1.Text = "radGridView1";
            // 
            // frmUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 488);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "frmUserGroup";
            this.radContextMenuManager1.SetRadContextMenu(this, this.radContextMenu1);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmUserGroup";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmUserGroup_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUserGroup_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupDescriptionRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNameRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox groupDescriptionRadTextBox;
        private Telerik.WinControls.UI.RadTextBox groupNameRadTextBox;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadContextMenuManager radContextMenuManager1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
