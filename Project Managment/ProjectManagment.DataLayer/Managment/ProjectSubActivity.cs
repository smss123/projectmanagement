using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagment.DataLayer.Managment
{
    public class ProjectSubActivity
    {
        public int ID { get; set; }
        public string SubActivityName { get; set; }
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime enddate { get; set; }
        public string Status { get; set; }
        public int Persentage { get; set; }
        public virtual Accountant.Account AcitvityAccount { get; set; }
        public virtual ProjectActivity projectProfile { get; set; }
        public virtual List<Expenses.ProjectExpenses> projectExpenses { get; set; }
       
    }
}