using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DataLayer.Commands.UserGroupCommand
{
   public  class xAttachments
    {
        private ProjectDbEntities db = new ProjectDbEntities();
        public bool AddAttachment(Attachment att)
        {
            try
            {
                db.Attachments.Add(att);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool EditAttachment(Attachment att)
        {
            try
            {
                var tb = db.Attachments.Where(a => a.ID == att.ID).SingleOrDefault();
                if (att.ID != null)
                {
                    tb.AttachmentName = att.AttachmentName; tb.CreateDate = att.CreateDate;
                    tb.fileContent = att.fileContent; tb.ProjectProfile = att.ProjectProfile;
                    tb.ProjectOrder = att.ProjectOrder;
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


        public bool DeleteCurrentAttachment(Attachment att)
        {
            try
            {
                var tb = db.Attachments.Where(a => a.ID == att.ID).SingleOrDefault();
                if (att.ID != null)
                {
                    db.Attachments.Remove(att);
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

        public List<Attachment> GetAllAttachments()
        {
            return (db.Attachments).ToList();
        }
    }
}
