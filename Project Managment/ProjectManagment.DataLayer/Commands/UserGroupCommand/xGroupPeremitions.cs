using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class xGroupPeremitions
    {

       private ProjectDbEntities db = new ProjectDbEntities();
       public bool AddPeremition(UserGroupPermession Per)
       {

           try
           {
               db.UserGroupPermessions.Add(Per);
               db.SaveChanges();
               return true;
           }
           
           catch (Exception)
           {

               return false;
           }
       }

       public bool EditGroupPeremitions(UserGroupPermession UsrPer)
       {
           try
           {
                  var p = db.UserGroupPermessions.Where(x => x.Id == UsrPer.Id).SingleOrDefault();
                   if (p.Id != null)
                   {
                       p.ValueX = UsrPer.ValueX;
                       p.Permession = UsrPer.Permession;
                       p.UserGroup = UsrPer.UserGroup;
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
       public bool DeletePeremtion(UserGroupPermession UsrPer)
       {

           try
           {
               var p = db.UserGroupPermessions.Where(x => x.Id == UsrPer.Id).SingleOrDefault();
               if (p.Id != null)
               {
                   db.UserGroupPermessions.Remove(UsrPer);
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

           public List <UserGroupPermession> GetAllPeremitions(){
               var AllPeremitions = ( from per in db .UserGroupPermessions
                                      orderby per .Id ascending
                                      select per ).ToList () ;
               return AllPeremitions ;

           }
       }


    }
}
