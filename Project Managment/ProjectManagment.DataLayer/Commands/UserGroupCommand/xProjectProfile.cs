using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class xProjectProfile
    {
        private ProjectDbEntities db = new ProjectDbEntities();


       public bool AddNewProject( ProjectProfile ptb){
           try 
	        {
                db.ProjectProfiles.Add(ptb); db.SaveChanges();
		    return true ;
	        }
	        catch (Exception)
	        {
		
		       return false ;
	        }
       }


       public bool EditProject(ProjectProfile ptb)
       {
           try
           {
               var tb = db.ProjectProfiles.Where(p => p.ID == ptb.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   tb.ProjectName = ptb.ProjectName;
                   tb.ProjectDescription = ptb.ProjectDescription;
                   tb.StartDate = ptb.StartDate;
                   tb.EndDate = ptb.EndDate;
                   tb.Status = ptb.Status;
                   tb.progress = ptb.progress;
                   tb.TotalCost = ptb.TotalCost;
                   db.SaveChanges();
                   return  true ;
               }else { return false ;}
           }
           catch (Exception)
           {

               return false;
           }
       }

       public bool DeleteProject(ProjectProfile ptb)
       {
           try
           {
               var tb = db.ProjectProfiles.Where(p => p.ID == ptb.ID).SingleOrDefault();
               if (tb.ID != null)
               {
                   db.ProjectProfiles.Remove(ptb);
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




        public List<ProjectProfile> GetAllProjects() { return (db.ProjectProfiles).ToList(); }


    }
}
