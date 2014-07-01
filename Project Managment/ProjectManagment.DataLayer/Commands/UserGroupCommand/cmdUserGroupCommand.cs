using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class cmdUserGroupCommand
    {
       private ProjectDbEntities db = new ProjectDbEntities();

       public bool AddGroup(UserGroup g)
       {
           try
           {
               db.UserGroups.Add(g);
               db.SaveChanges();
               return true;
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
       }
       public bool EditGroup(UserGroup g)
       {
           try
           {
               var q = db.UserGroups.Where(p => p.ID == g.ID).SingleOrDefault();
               if (q != null)
               {
                   q.GroupName = g.GroupName;
                   q.GroupDescription = g.GroupDescription;
                   q.UserGroupPermessions = g.UserGroupPermessions;
                   db.SaveChanges();
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
       }
    }
}
