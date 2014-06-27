using System;

namespace ProjectManagment.DataLayer.Accountant
{
   public  class Transaction
    {
        public int ID { get; set; }
        public DateTime  DateOfTransaction { get; set; }
        public double  TotalIn { get; set; }
        public double  TotalOut { get; set; }
        public string  Description { get; set; }
        public string  CommandNames { get; set; }
        public  virtual  Account  account { get; set; }
    }
}


