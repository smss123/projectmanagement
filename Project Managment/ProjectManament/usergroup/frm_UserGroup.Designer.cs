namespace ProjectManament.usergroup
{
    partial class frm_UserGroup
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.GroupNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.GroupDescriptionTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلمجموعةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بحثCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بحثactrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفمجموعةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقctrlxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDescriptionTextBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(192, 49);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(73, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "اسم المجموعة";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Location = new System.Drawing.Point(34, 49);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(152, 22);
            this.GroupNameTextBox.TabIndex = 2;
            this.GroupNameTextBox.ThemeName = "TelerikMetro";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(192, 84);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(41, 18);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "الوصف";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // GroupDescriptionTextBox
            // 
            this.GroupDescriptionTextBox.AutoSize = false;
            this.GroupDescriptionTextBox.Location = new System.Drawing.Point(34, 84);
            this.GroupDescriptionTextBox.Multiline = true;
            this.GroupDescriptionTextBox.Name = "GroupDescriptionTextBox";
            this.GroupDescriptionTextBox.Size = new System.Drawing.Size(152, 75);
            this.GroupDescriptionTextBox.TabIndex = 4;
            this.GroupDescriptionTextBox.ThemeName = "TelerikMetro";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.تعديلمجموعةToolStripMenuItem,
            this.بحثCtrlAToolStripMenuItem,
            this.بحثactrlToolStripMenuItem,
            this.حذفمجموعةToolStripMenuItem,
            this.اغلاقToolStripMenuItem,
            this.اغلاقctrlxToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 158);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addToolStripMenuItem.Text = "اضافة مجموعةctrl+s";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // تعديلمجموعةToolStripMenuItem
            // 
            this.تعديلمجموعةToolStripMenuItem.Name = "تعديلمجموعةToolStripMenuItem";
            this.تعديلمجموعةToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.تعديلمجموعةToolStripMenuItem.Text = "تعديل مجموعةctrl+e";
            // 
            // بحثCtrlAToolStripMenuItem
            // 
            this.بحثCtrlAToolStripMenuItem.Name = "بحثCtrlAToolStripMenuItem";
            this.بحثCtrlAToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.بحثCtrlAToolStripMenuItem.Text = "بحث ctrl+ a";
            // 
            // بحثactrlToolStripMenuItem
            // 
            this.بحثactrlToolStripMenuItem.Name = "بحثactrlToolStripMenuItem";
            this.بحثactrlToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.بحثactrlToolStripMenuItem.Text = "بحث +actrl";
            // 
            // حذفمجموعةToolStripMenuItem
            // 
            this.حذفمجموعةToolStripMenuItem.Name = "حذفمجموعةToolStripMenuItem";
            this.حذفمجموعةToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.حذفمجموعةToolStripMenuItem.Text = "حذف مجموعةctrl+D";
            // 
            // اغلاقToolStripMenuItem
            // 
            this.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem";
            this.اغلاقToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.اغلاقToolStripMenuItem.Text = "بحث ctl+ I";
            this.اغلاقToolStripMenuItem.Click += new System.EventHandler(this.اغلاقToolStripMenuItem_Click);
            // 
            // اغلاقctrlxToolStripMenuItem
            // 
            this.اغلاقctrlxToolStripMenuItem.Name = "اغلاقctrlxToolStripMenuItem";
            this.اغلاقctrlxToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.اغلاقctrlxToolStripMenuItem.Text = "اغلاقctrl+x";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radTextBox1);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.GroupNameTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.GroupDescriptionTextBox);
            this.radGroupBox1.HeaderText = "مجموعات المستخدمين";
            this.radGroupBox1.Location = new System.Drawing.Point(344, 23);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(291, 175);
            this.radGroupBox1.TabIndex = 8;
            this.radGroupBox1.Text = "مجموعات المستخدمين";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(34, 21);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.ReadOnly = true;
            this.radTextBox1.Size = new System.Drawing.Size(152, 22);
            this.radTextBox1.TabIndex = 2;
            this.radTextBox1.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(192, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "رقم المجموعة";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.White;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(-1, 214);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.AllowResize = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "رقم المجموعة";
            gridViewTextBoxColumn1.Name = "colID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 174;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "اسم المجموعة";
            gridViewTextBoxColumn2.Name = "colGroupName";
            gridViewTextBoxColumn2.Width = 215;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "وصف";
            gridViewTextBoxColumn3.Name = "colDecription";
            gridViewTextBoxColumn3.Width = 229;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            sortDescriptor1.PropertyName = "column1";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(636, 262);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetro";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.checkedListBox1);
            this.radGroupBox2.HeaderText = "الصلاحيات";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 23);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(298, 175);
            this.radGroupBox2.TabIndex = 10;
            this.radGroupBox2.Text = "الصلاحيات";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Add",
            "Delete",
            "Edi"});
            this.checkedListBox1.Location = new System.Drawing.Point(2, 18);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(294, 155);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // frm_UserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 486);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "frm_UserGroup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مجموعات المستخدمين";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frm_UserGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDescriptionTextBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox GroupNameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox GroupDescriptionTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلمجموعةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفمجموعةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقToolStripMenuItem;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.ToolStripMenuItem بحثCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بحثactrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقctrlxToolStripMenuItem;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;

    }
}
