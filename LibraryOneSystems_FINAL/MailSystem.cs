using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net.Mail;
using System.Threading;

namespace EMAIL
{
    public static class skylight
    {
        public static void send(string emailTo, string title, string msg)
        {
            new Thread(() => work(emailTo, title, msg)).Start();
        }

        static void work(string emailTo, string title, string msg)
        {
            try
            {
                MailMessage mail = new MailMessage("skylight.hotelpay@gmail.com", emailTo, title, msg);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("skylight.hotelpay@gmail.com", "skylighthotel");
                client.EnableSsl = true;
                client.Send(mail);
            }
            catch(Exception ex)
            {
                MailMessage crashMail = new MailMessage("skylight.hotelpay@gmail.com", skylight.hotelpay@gmail.com, Mail Failed, ex.message.toString());
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("skylight.hotelpay@gmail.com", "skylighthotel");
                client.EnableSsl = true;
                client.Send(crashMail);	
	    }
        }

    }
}
