using ProjectManagment.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.Entity;
using System.Data.Linq;

namespace ProjectManament.usergroup
{
    public partial class frm_UserGroup : Telerik.WinControls.UI.RadForm
    {
        public frm_UserGroup()
        {
            InitializeComponent();
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_UserGroup_Load(object sender, EventArgs e)
        {

        }

        #region "FormCode"
        private dbContext db = new dbContext();
        private void AddNew()
        {
            UserGroups g = new UserGroups()
            {
                GroupName = GroupNameTextBox.Text,
                GroupDescription = GroupDescriptionTextBox.Text
            };
            for (int i = 0; i < checkedListBox1.Items.Count ; i++)
            {
                g.Permessions.Add(new GroupPermession()
                {
                    PermesionName = checkedListBox1.Items[i].ToString(),
                    Value = checkedListBox1.GetItemChecked(i)

                });
               
            }
            db.userGroups.Add(g);
            db.SaveChanges();
            MessageBox.Show("done");
        }
        private void Edit()
        {
           // var q = (from i in db.userGroups.Local.GetEnumerator() where i.id == radTextBox1.Text select i);
            db = new dbContext();
           

        }
        #endregion

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNew();
        }
    }
}