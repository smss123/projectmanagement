using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagment.Forms.UserGroup;
namespace ProjectManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // ProjectManagment.DataLayer.dbContext db = new DataLayer.dbContext();
          
        private void Form1_Load(object sender, EventArgs e)
        {
            // var q = (from i in db.accounts select i);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  textBox1.Text = db.Database.Connection.ConnectionString;

            frmUserGroup frmgroup = new frmUserGroup();
            frmgroup.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSystemUser frmuser = new frmSystemUser();
            frmuser.ShowDialog();
        }
    }
}
