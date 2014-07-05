namespace ProjectManagment.Forms.UserGroup
{
    partial class frmSystemUser
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.groupUserComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.PasswordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.UserNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.SystemUserGridView = new Telerik.WinControls.UI.RadGridView();
            this.btnNew = new Telerik.WinControls.UI.RadMenuItem();
            this.btnAdd = new Telerik.WinControls.UI.RadMenuItem();
            this.btnEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenu1 = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.lblmsg = new Telerik.WinControls.UI.RadLabelElement();
            this.btnDelete = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUserComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUserComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUserComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUserGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblmsg});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 482);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(881, 25);
            this.radStatusStrip1.TabIndex = 5;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "TelerikMetro";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 29);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(881, 192);
            this.radPanel1.TabIndex = 7;
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanel1.ThemeName = "TelerikMetro";
            this.radPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radPanel1_MouseDown);
            this.radPanel1.MouseHover += new System.EventHandler(this.radPanel1_MouseHover);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.groupUserComboBox);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.PasswordTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.UserNameTextBox);
            this.radGroupBox1.Controls.Add(this.radTextBox1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radGroupBox1.HeaderText = "بيانات المستخدم";
            this.radGroupBox1.Location = new System.Drawing.Point(495, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radContextMenuManager1.SetRadContextMenu(this.radGroupBox1, this.radContextMenu1);
            this.radGroupBox1.Size = new System.Drawing.Size(386, 192);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "بيانات المستخدم";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.Location = new System.Drawing.Point(305, 109);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(44, 18);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "المجموعة:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupUserComboBox
            // 
            // 
            // groupUserComboBox.NestedRadGridView
            // 
            this.groupUserComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.groupUserComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupUserComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupUserComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.groupUserComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.groupUserComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.groupUserComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.groupUserComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.groupUserComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.groupUserComboBox.EditorControl.Name = "NestedRadGridView";
            this.groupUserComboBox.EditorControl.ReadOnly = true;
            this.groupUserComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupUserComboBox.EditorControl.ShowGroupPanel = false;
            this.groupUserComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.groupUserComboBox.EditorControl.TabIndex = 0;
            this.groupUserComboBox.Location = new System.Drawing.Point(114, 109);
            this.groupUserComboBox.Name = "groupUserComboBox";
            this.groupUserComboBox.Size = new System.Drawing.Size(175, 20);
            this.groupUserComboBox.TabIndex = 3;
            this.groupUserComboBox.TabStop = false;
            this.groupUserComboBox.Text = "اختر المجموعة";
            this.groupUserComboBox.ThemeName = "TelerikMetro";
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Location = new System.Drawing.Point(305, 76);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(53, 18);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "كلمة المرور:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(114, 81);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(175, 22);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Location = new System.Drawing.Point(305, 53);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(60, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "اسم المجموعة:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(305, 29);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(26, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "الرقم:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameTextBox.Location = new System.Drawing.Point(114, 53);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(175, 22);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.ThemeName = "TelerikMetro";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBox1.Location = new System.Drawing.Point(114, 25);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.ReadOnly = true;
            this.radTextBox1.Size = new System.Drawing.Size(175, 22);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.ThemeName = "TelerikMetro";
            // 
            // SystemUserGridView
            // 
            this.SystemUserGridView.BackColor = System.Drawing.Color.White;
            this.SystemUserGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SystemUserGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemUserGridView.Font = new System.Drawing.Font("Tahoma", 8F);
            this.SystemUserGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SystemUserGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SystemUserGridView.Location = new System.Drawing.Point(0, 221);
            // 
            // SystemUserGridView
            // 
            this.SystemUserGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "الرقم";
            gridViewTextBoxColumn5.Name = "UserIDColm";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 104;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "اسم المستخدم";
            gridViewTextBoxColumn6.Name = "userNameColm";
            gridViewTextBoxColumn6.Width = 270;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.HeaderText = "كلمة المرور";
            gridViewTextBoxColumn7.Name = "passwordColm";
            gridViewTextBoxColumn7.Width = 300;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.HeaderText = "اسم المجموعة";
            gridViewTextBoxColumn8.Name = "GroupUserClom";
            gridViewTextBoxColumn8.Width = 190;
            this.SystemUserGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.SystemUserGridView.MasterTemplate.EnableFiltering = true;
            this.SystemUserGridView.Name = "SystemUserGridView";
            this.SystemUserGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SystemUserGridView.Size = new System.Drawing.Size(881, 261);
            this.SystemUserGridView.TabIndex = 8;
            this.SystemUserGridView.Text = "radGridView2";
            this.SystemUserGridView.ThemeName = "TelerikMetro";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "جديد";
            this.btnNew.AccessibleName = "جديد";
            this.btnNew.Name = "btnNew";
            this.btnNew.Text = "جديد";
            this.btnNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "اضافة";
            this.btnAdd.AccessibleName = "اضافة";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleDescription = "تعديل";
            this.btnEdit.AccessibleName = "تعديل";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radContextMenu1
            // 
            this.radContextMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnNew,
            this.btnAdd,
            this.btnEdit});
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnNew,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.radMenu1.Size = new System.Drawing.Size(881, 29);
            this.radMenu1.TabIndex = 6;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "TelerikMetro";
            // 
            // lblmsg
            // 
            this.lblmsg.AccessibleDescription = "msg";
            this.lblmsg.AccessibleName = "msg";
            this.lblmsg.Name = "lblmsg";
            this.radStatusStrip1.SetSpring(this.lblmsg, false);
            this.lblmsg.Text = "msg";
            this.lblmsg.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblmsg.TextWrap = true;
            this.lblmsg.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "حذف";
            this.btnDelete.AccessibleName = "حذف";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "حذف";
            this.btnDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 507);
            this.Controls.Add(this.SystemUserGridView);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radStatusStrip1);
            this.MaximumSize = new System.Drawing.Size(889, 542);
            this.MinimumSize = new System.Drawing.Size(889, 542);
            this.Name = "frmSystemUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(889, 542);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.frmSystemUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUserComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUserComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUserComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUserGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadMenuItem btnNew;
        private Telerik.WinControls.UI.RadMenuItem btnAdd;
        private Telerik.WinControls.UI.RadMenuItem btnEdit;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox PasswordTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox UserNameTextBox;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadGridView SystemUserGridView;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu1;
        private Telerik.WinControls.UI.RadContextMenuManager radContextMenuManager1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadMultiColumnComboBox groupUserComboBox;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadLabelElement lblmsg;
        private Telerik.WinControls.UI.RadMenuItem btnDelete;

    }
}
