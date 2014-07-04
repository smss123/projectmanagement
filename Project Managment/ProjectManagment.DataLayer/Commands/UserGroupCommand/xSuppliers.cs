using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class xSuppliers
    {
        ProjectDbEntities db = new ProjectDbEntities();

       public bool AddNewSupplier( Supplier sp){
           try
           {
               db.Suppliers.Add(sp); db.SaveChanges();
               return true;
           }
           catch (Exception)
           {

               return false;
           }
       }


       public bool EditSupplier(Supplier sp)
       {
           try
           {
               var tb = db.Suppliers.Where(p => p.ID == sp.ID).SingleOrDefault();
               if (tb.ID != null)
               {


                   tb.name = sp.name;
                   tb.PhoneNumber = sp.PhoneNumber;
                   tb.SuppliersNatural = sp.SuppliersNatural;
                   tb.Fax = sp.Fax;
                   tb.Email = sp.Email;
                   tb.Adderss = sp.Adderss;
                   tb.ProjectExpen = sp.ProjectExpen;
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



       public bool DeleteSupplier(Supplier sp)
       {
           try
           {
               var tb = db.Suppliers.Where(p => p.ID == sp.ID).SingleOrDefault();
               if (tb.ID != null)
               {

                   db.Suppliers.Remove(sp); 
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

       public List<Supplier> GetAllSuppliers() { return (db.Suppliers).ToList(); }


    }
}
