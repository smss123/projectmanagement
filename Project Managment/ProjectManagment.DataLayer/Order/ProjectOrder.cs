using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagment.DataLayer.Order
{
     public    class ProjectOrder
    {
         public int ID { get; set; }
         public string OrderTitle { get; set; }
         public string OrderBody { get; set; }

         public DateTime OrderDate { get; set; }

         public virtual  List<Attachment> OrderAttachment { get; set; }

         public virtual Managment.ProjectProfile projectProfile  { get; set; }


    }
}
