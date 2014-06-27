
namespace ProjectManagment.DataLayer
{
   public  class SystemUser
    {
        public int ID { get; set; }
        public string  UserName { get; set; }
        public string  Password { get; set; }
        public virtual  UserGroups  Group { get; set; }
    }
}
