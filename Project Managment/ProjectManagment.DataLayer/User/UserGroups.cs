using System.Collections.Generic;

namespace ProjectManagment.DataLayer
{
   public  class UserGroups
    {
        public int ID { get; set; }
        public string  GroupName { get; set; }
        public string  GroupDescription { get; set; }
        public  virtual List<SystemUser> Users { get; set; }
    }
}
