
namespace ProjectManagment.DataLayer
{
   public  class GroupPermession
    {
        public int ID { get; set; }
        public string  PermesionName { get; set; }
        public bool  Value { get; set; }
        public virtual UserGroups  UserGroup { get; set; }





    }
}
