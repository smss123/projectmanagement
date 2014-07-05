using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class xProjectActivities
    {
       ProjectDbEntities db = new ProjectDbEntities();
       public bool AddActivity( ProjectActivity tb)
       {
           try
           {
               db.ProjectActivities.Add(tb);
               db.SaveChanges();
               return true;
           }
           catch (Exception)
           {

               return false;
           }
       }





       public bool EditActivity(ProjectActivity act)
       {
           try
           {
               var tb = db.ProjectActivities.Where(a => a.ID == act.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   tb.ActivityName = act.ActivityName;
                   tb.Description = act.Description;
                   tb.StartDate = act.StartDate;
                   tb.EndDate = act.EndDate;
                   tb.Status = act.Status;
                   tb.Progress = act.Progress;
                   tb.TotalCost = act.TotalCost;
                   tb.ProjectProfile = act.ProjectProfile;
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

       public bool DeleteCurrentActivity(ProjectActivity act)
       {
           try
           {
               var tb = db.ProjectActivities.Where(a => a.ID == act.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   db.ProjectActivities.Remove(act);
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



       public List<ProjectActivity> GetAllActivities() { return (db.ProjectActivities).ToList(); }


    }
}
