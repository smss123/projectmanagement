using ProjectManagment.DataLayer.Managment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagment.DataLayer.Employee
{
   public  class Contracts
    {
        public int ID { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime  EndDate { get; set; }
        public double  SelaryAmount { get; set; }
        public virtual Employee employee { get; set; }
        public virtual Accountant.Account   EmplyeeAccount { get; set; }
        public bool  Status { get; set; }
        public virtual  SystemUser LoginInformation { get; set; }
      


    }
}
