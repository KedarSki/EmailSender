using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    class EmailSender
    {
        string from = "radoslaw.zamojski@gmail.com";
        public string to = " ";
        public string body = " ";

        public void emailsend ()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = "Test Mail";
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("email@gmail.com", "Password");
                SmtpServer.EnableSsl = true;
                
                SmtpServer.Send(mail);
                MessageBox.Show("E-mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
