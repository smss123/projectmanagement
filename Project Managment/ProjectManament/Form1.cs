using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectManagment.DataLayer;
namespace ProjectManament
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbContext db = new dbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //var q = from i in db.accounts select i;
   
                    
                    }

        private void button1_Click(object sender, EventArgs e)
        {

            var q = from i in db.accounts select i;
            textBox1.Text = db.Database.Connection.ConnectionString;
        }
    }
}
