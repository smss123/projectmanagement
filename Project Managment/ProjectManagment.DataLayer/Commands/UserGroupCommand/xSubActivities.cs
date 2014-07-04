using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
    public class xSubActivities
    {
        ProjectDbEntities db = new ProjectDbEntities();
        public bool AddSubActivity(ProjectSubActivity sbAct)
        {
            try
            {
                db.ProjectSubActivities.Add(sbAct);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool EditSubActivity(ProjectSubActivity sbAct)
        {
            try
            {
                var tb = db.ProjectSubActivities.Where(s => s.ID == sbAct.ID).SingleOrDefault();
                if (tb.ID != null)
                {
                    tb.SubActivityName = sbAct.SubActivityName;
                    tb.Description = sbAct.Description;
                    tb.Startdate = sbAct.Startdate;
                    tb.enddate = sbAct.enddate;
                    tb.Status = sbAct.Status;
                    tb.Persentage = sbAct.Persentage;
                    tb.ProjectActivity = sbAct.ProjectActivity;
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

        public bool DeleteSubActivity(ProjectSubActivity sbAct)
        {
            try
            {

                var tb = db.ProjectSubActivities.Where(s => s.ID == sbAct.ID).SingleOrDefault();
                if (tb.ID != null)
                {
                    db.ProjectSubActivities.Remove(sbAct);
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


        public List<ProjectSubActivity> GetAllSubActivities() { return (db.ProjectSubActivities).ToList(); }
      
    }
}
