using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
     public class xContracts
    {
         ProjectDbEntities db = new ProjectDbEntities();
         public bool AddContract( Contract cn) {
             try
             {
                 db.Contracts.Add(cn);
                 db.SaveChanges();
                 return true;
             }
             catch (Exception)
             {

                 return false;
             }
         }



         public bool EditContract(Contract cn)
         {
             try
             {
                 var c = db.Contracts.Where(x => x.ID == cn.ID).SingleOrDefault();
                 if (c.ID != null)
                 {
                     c.StartDate = cn.StartDate; 
                     c.EndDate = cn.EndDate;
                     c.SelaryAmount = cn.SelaryAmount;
                     c.Status = cn.Status;
                     c.EmplyeeAccount_ID = cn.EmplyeeAccount_ID;
                     c.Employee = cn.Employee;
                     c.ProjectProfile = cn.ProjectProfile;
                    
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


         public bool DeleteContract(Contract cn)
         {
             try
             {
                 var c = db.Contracts.Where(x => x.ID == cn.ID).SingleOrDefault();
                 if (c.ID != null)
                 {
                     db.Contracts.Remove(cn);
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

         public List<Contract> GetAllContracts()
         {
             return (db.Contracts).ToList();
         }

    }
}
