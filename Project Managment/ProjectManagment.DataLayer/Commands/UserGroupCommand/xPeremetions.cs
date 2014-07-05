using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class xPeremetions
    {
       private ProjectDbEntities db = new ProjectDbEntities();
       public bool AddPermetions(Permession per)
       {
           try
           {
               db.Permessions.Add(per);
               db.SaveChanges();
               return true;
           }
           catch (Exception)
           {
               return false;
           }
       }



       public bool EditPermetions(Permession per)
       {
           try
           {
               var tb = db.Permessions.Where(p => p.ID == per.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   tb.PermessionName = per.PermessionName;
                   tb.PropertyName = per.PropertyName;
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

       public bool DeleteCurrentPeremtions(Permession per )
       {

           try
           {
               var tb = db.Permessions.Where(p => p.ID == per.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   db.Permessions.Remove(per);
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
           public List <Permession > GetAllPermssions(){

               return (db.Permessions).ToList();
           }
      
    }
}
