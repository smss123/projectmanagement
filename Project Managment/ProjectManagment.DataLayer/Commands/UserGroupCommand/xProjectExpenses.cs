using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class xProjectExpenses
    {

       ProjectDbEntities db = new ProjectDbEntities();
       public bool AddExpense (ProjectExpens exp)
       {
           try
           {
               db.ProjectExpenses.Add(exp); db.SaveChanges(); return true;
           }
           catch (Exception)
           {

               return false;
           }
       }

       public bool EditExpense(ProjectExpens exp)
       {
           try
           {
             var   tb = db.ProjectExpenses.Where(x => x.ID == exp.ID 
                 && x.DateofProcess == exp .DateofProcess ).SingleOrDefault();
             if (tb.ID != null)
             {
                 tb.ExpensesName = exp.ExpensesName;
                 tb.DateofProcess = exp.DateofProcess;
                 tb.BillNumber = exp.BillNumber;
                 tb.RequiarAmount = exp.RequiarAmount;
                 tb.CashingNumber = exp.CashingNumber;
                 tb.ProjectSubActivity = exp.ProjectSubActivity;
                 db.SaveChanges();
                 return true;
             }
             else { return false; }
              
           }
           catch (Exception)
           {

               return false;
           }
       }


       public bool DeleteExpense(ProjectExpens exp)
       {
           try
           {
               var tb = db.ProjectExpenses.Where(x => x.ID == exp.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   db.ProjectExpenses.Remove(exp);
                   db.SaveChanges();
                   return true;
               }
               else { return false; }

           }
           catch (Exception)
           {

               return false;
           }
       }

       public List<ProjectExpens> GetAllExpenses() { return (db.ProjectExpenses).ToList(); }

       public List<ProjectExpens> GetExpensesByDay( DateTime Dy)
       { return ( from d in db.ProjectExpenses where d.DateofProcess == Dy select d ).ToList(); }

    }
}
