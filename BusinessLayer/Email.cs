using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using ExceptionUtility;
using ClassEntities;
using DataAccessLayer;

namespace BusinessLayer
{
  public class Email : BALInterface.IEmail
    {
        public void sendMails(UserInfo userInfo)
        {
            
        
        }

        internal void sendMails(userinfo objUserDetails)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                MailMessage mailMessage = new MailMessage();

                mailMessage.To.Add(new MailAddress("sitalmandal.info@gmail.com"));
                mailMessage.Subject = "mailSubject";
                mailMessage.Body = "mailBody";

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                CubitExceptionUtility.CubitExceptionLog(ex.Message + "BAL: Error while sending mail " + ex.StackTrace + " " + ex.InnerException, this.GetType().BaseType.Name.ToString(), DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }
    }
}
