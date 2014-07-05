using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class xEmployees
    {
       private ProjectDbEntities db = new ProjectDbEntities();
       public bool AddEmployee(Employee Emp)
       {
           try
           {
               db.Employees.Add(Emp);
               db.SaveChanges();
               return true;
           }
           catch (Exception)
           {

               return false;
           }

       }

       public bool EditEmployee(Employee emp)
       {
           try
           {
               var tb = db.Employees.Where(m => m.ID == emp.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   tb.EmployeejobNumber = emp.EmployeejobNumber;
                   tb.EmployeeName = emp.EmployeeName;
                   tb.EmployeeGender = emp.EmployeeGender;
                   tb.EmployeeNationalNumber = emp.EmployeeNationalNumber;
                   tb.PhoneNumber = emp.PhoneNumber;
                   tb.Email = emp.Email;
                   tb.Mobilenumber = emp.Mobilenumber;
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

       public bool DeleteEmployee(Employee emp)
       {
           try
           {
               var tb = db.Employees.Where(m => m.ID == emp.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   db.Employees.Remove(emp);
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

       public List<Employee> GetAllEmployees()
       {

           var AllEmp = (from m in db.Employees
                         orderby m.EmployeeName ascending
                         select m).ToList();
           return AllEmp;
       }

       public List<Employee> GetEmployeeByID(int XID )
       {

           var AllEmp = (from m in db.Employees
                         where m.ID == XID 
                         select m).ToList();
           return AllEmp;
       }

    }
}
