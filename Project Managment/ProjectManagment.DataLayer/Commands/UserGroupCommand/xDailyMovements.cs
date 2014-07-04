using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
    public class xDailyMovements
    {
        ProjectDbEntities db = new ProjectDbEntities();
        public bool AddMovement(DailyMovemnt Dy)
        {
            try
            {
                db.DailyMovemnts.Add(Dy);
                db.SaveChanges();
                return true;
                
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool EditMovement(DailyMovemnt dy)
        {
            try
            {
                var tb = db.DailyMovemnts.Where(d => d.ID == dy.ID).SingleOrDefault();
                if (tb.ID != null)
                {
                    tb.FromAccout = dy.FromAccout;
                    tb.ToAccount = dy.ToAccount;
                    tb.Amount = dy.Amount;
                    tb.Description = dy.Description;
                    tb.DateOfProcess = dy.DateOfProcess;
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

        public bool DeleteMovement(DailyMovemnt Dy)
        {
            try
            {
                var tb = db.DailyMovemnts.Where(d => d.ID == Dy.ID).SingleOrDefault();
                if (tb.ID != null)
                {
                    db.DailyMovemnts.Remove(Dy);
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
        public List<DailyMovemnt> GetAllMovemnts() { return (db.DailyMovemnts).ToList(); }

        public List<DailyMovemnt> GetMovemntByDate(DateTime Dy) {

            var xDy = (from d in db.DailyMovemnts
                       where
                           d.DateOfProcess == Dy
                       select d).ToList();
            return xDy;
        }
    }
}
