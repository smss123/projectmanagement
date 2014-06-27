using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagment.DataLayer.Accountant
{
   public  class DailyMovemnt
    {
        public int  ID { get; set; }
        public int FromAccout { get; set; }
        public int ToAccount { get; set; }
        public double  Amount { get; set; }
        public string  Description { get; set; }
        public DateTime  DateOfProcess { get; set; }
    }
}
