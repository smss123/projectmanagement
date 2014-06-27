
using System.Collections.Generic;
namespace ProjectManagment.DataLayer.Accountant
{
   public  class Account
    {
        public int ID { get; set; }
        public string  AccountName { get; set; }
        public string  AccountDescription { get; set; }
       /// <summary>
       /// العملات هنا
       /// </summary>
        public string  Coin { get; set; }

       /// <summary>
       /// هذا الحقل لتحديد طبيعه الحساب هل هو دائن او مدين
       /// </summary>
        public string  AccountNatural { get; set; }
        public List<Transaction> Transactions { get; set; }

       
    }
}
