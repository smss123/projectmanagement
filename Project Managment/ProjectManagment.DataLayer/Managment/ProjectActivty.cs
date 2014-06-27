using System;
using System.Collections.Generic;

namespace ProjectManagment.DataLayer.Managment
{
   public  class ProjectActivity
    {
        public int ID { get; set; }
        public string  ActivityName { get; set; }
        public string  Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int Progress { get; set; }
        public virtual Accountant.Account AcitvityAccount { get; set; }
        public virtual List<ProjectSubActivity> SubActivity { get; set; }
        public virtual ProjectProfile  projectProfile { get; set; }

    }
}
