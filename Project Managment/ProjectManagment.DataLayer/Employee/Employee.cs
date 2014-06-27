using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagment.DataLayer.Employee
{
   public  class Employee
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeejobNumber { get; set; }
       /// <summary>
       /// نوع اثبات الشخصيه
       /// 
       /// </summary>
        public string EmployeeGender { get; set; }

       /// <summary>
       /// رقم اثبات الشخصيه
       /// </summary>
        public string EmployeeNationalNumber { get; set; }
        public string  PhoneNumber { get; set; }
        public string Mobilenumber { get; set; }
        public string  Email { get; set; }
    }
}
