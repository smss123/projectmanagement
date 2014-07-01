using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.Linq;
using ProjectManagment.DataLayer;
namespace ProjectManament.usergroup
{
    public partial class frmUserGroup : Telerik.WinControls.UI.RadForm
    {
        public frmUserGroup()
        {
            InitializeComponent();
        }

        private dbContext db = new dbContext();

        private void FrmUserGroupLoad(object sender, EventArgs e)
        {
          
        }
    }
}
