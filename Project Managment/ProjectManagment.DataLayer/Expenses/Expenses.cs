using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagment.DataLayer.Expenses
{
    public class ProjectExpenses
    {
        public int ID { get; set; }
        public string ExpensesName { get; set; }
        public DateTime DateofProcess { get; set; }
        public virtual Suppler.Suppliers SupplerName { get; set; }
        public string BillNumber { get; set; }
        public double RequiarAmount { get; set; }
        public string CashingNumber { get; set; }
        
        public bool OkyProjectManager { get; set; }
        public DateTime DateOfOkProjectManager { get; set; }
        public string ProjectMnagerComment { get; set; }
        public virtual Managment.ProjectSubActivity  SubActivity   { get; set; }
        public bool OkyFainancManager { get; set; }
        public DateTime DateOfOkyFainancManager { get; set; }
        public string FainancManagerComment { get; set; }


        public bool OkyAuditManager { get; set; }
        public DateTime DateOfOkyAuditManager { get; set; }
        public string AuditManagerComment { get; set; }


        public bool OkyAdministrativeManager { get; set; }
        public DateTime DateOfOkyAdministrativeManager { get; set; }
        public string AdministrativeManagerComment { get; set; }


        public bool OkyPresident { get; set; }
        public DateTime DateOfOkyPresident { get; set; }
        public string PresidentComment { get; set; }

    }
}
