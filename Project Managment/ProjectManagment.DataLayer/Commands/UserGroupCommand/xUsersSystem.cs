using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{



    public class xUsersSystem
    {
        private   ProjectDbEntities db = new ProjectDbEntities();

        public bool AddSystemUser( SystemUser Usr)
        {
            try
            {
                db.SystemUsers.Add(Usr);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool EditSystemUser(SystemUser Usr)
        {
            try
            {
             var U =   db.SystemUsers.Where(p => p.ID == Usr.ID).SingleOrDefault();
             if (U .ID  != null)
             {
                 U.UserName = Usr.UserName;
                 U.Password = Usr.Password;
                 U.UserGroup = Usr.UserGroup;
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


        public  bool  UserLogin(string UsrName, string UsrPass)
        {

            try
            {

                var GetUsr = (from U in db.SystemUsers
                              where U.UserName == UsrName && U.Password == UsrPass
                              select U).SingleOrDefault();
                if (GetUsr.ID != null)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
              
            }
        }


        public bool DeleteUser(SystemUser Usr)
        {
            try
            {
                var U = db.SystemUsers.Where(p => p.ID == Usr.ID).SingleOrDefault();
                if (U.ID != null)
                {
                    db.SystemUsers.Remove(Usr);
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
        public List<SystemUser> GetAllUsers() { 
         var  AllUsers = ( from u in db.SystemUsers   orderby u.UserName ascending select u ).ToList();
         return AllUsers;
        }
    }
}
