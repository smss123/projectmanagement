using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectManagment.DataLayer;
using Telerik.WinControls;

namespace ProjectManagment.Forms.UserGroup
{
    public partial class frmUserGroup : Telerik.WinControls.UI.RadForm
    {
        private ProjectDbEntities db = new ProjectDbEntities();

        public frmUserGroup()
        {
            InitializeComponent();
        }

        private void frmUserGroup_MouseDown(object sender, MouseEventArgs e)
        {
           // radContextMenu1.Show(e.X, e.Y);
        }

        private void frmUserGroup_Load(object sender, EventArgs e)
        {
            BindContextMenu();
          
           


        }

        private void BindContextMenu()
        {
            radContextMenu1.Items[0].Click += frmUserGroup_Click;
        }

        void frmUserGroup_Click(object sender, EventArgs e)
        {
           

         

        }


        public void Add()
        {

        }
      
    }
}
