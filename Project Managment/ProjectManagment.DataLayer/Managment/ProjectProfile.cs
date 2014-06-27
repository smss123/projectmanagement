using System;
using System.Collections.Generic;

namespace ProjectManagment.DataLayer.Managment
{
   public  class ProjectProfile
    {
        public int ID { get; set; }
        public string  ProjectName { get; set; }
        public string  ProjectDescription { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string  Status { get; set; }
        public int progress { get; set; }
        public virtual Accountant.Account  ProjectAccount { get; set; }
        public List<Employee.Contracts> employees { get; set; }
        public virtual List<Order.ProjectOrder> ProjectOrder { get; set; }
        public virtual List<Order.Attachment> Attachment { get; set; }
        public virtual List<Suppler.Thefinancier> Thefinancieres { get; set; }
       // public virtual List<> MyProperty { get; set; }
    }
}
