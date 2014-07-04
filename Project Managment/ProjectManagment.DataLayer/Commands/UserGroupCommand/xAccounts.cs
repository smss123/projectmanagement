using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
    public class xAccounts
    {
        private ProjectDbEntities db = new ProjectDbEntities();

        public bool AddNewAccount(Account Act)
        {
            try
            {
                db.Accounts.Add(Act);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool EditAccount(Account act)
        {
            try
            {
                var tb = db.Accounts.Where(A => A.ID == act.ID).SingleOrDefault();
                if (tb.ID != null)
                {
                    tb.AccountName = act.AccountName;
                    tb.AccountDescription = act.AccountDescription;
                    tb.AccountNatural = act.AccountNatural;
                    tb.Coin = act.Coin;
                    tb.ProjectActivity = act.ProjectActivity;
                    tb.ProjectProfile = act.ProjectProfile; 
                    tb.ProjectSubActivity = act.ProjectSubActivity;
                    tb.Contract = act.Contract;
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
           public bool DeleteCurrentAccount( Account act ){

               try
               {
                   var tb = db.Accounts.Where(A => A.ID == act.ID).SingleOrDefault();
                   if (tb.ID != null)
                   {
                       db.Accounts.Remove(act);
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


           public List<Account> GetAllAccounts()
           {
               var AllAcct = (from ac in db.Accounts
                              orderby ac.ID ascending
                              select ac).ToList();
               return AllAcct;
           }

           public List<Account> GetAccountsByCoin(string con)
           {
               var AllAcct = (from ac in db.Accounts
                              orderby ac.ID ascending
                              where ac.Coin == con 
                              select ac).ToList();
               return AllAcct;
           }
           public List<Account> GetAccountsByID(int XID )
           {
               var AllAcct = (from ac in db.Accounts
                              where ac.ID == XID select ac).ToList ();

               return AllAcct;
           }

    }
}
