using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectManagment.DataLayer.Order
{
    public  class Attachment
    {
        public int ID { get; set; }
        public string  AttachmentName { get; set; }
      // public Image FileContent { get; set; }
        public DateTime  CreateDate { get; set; }
       
    }
}
