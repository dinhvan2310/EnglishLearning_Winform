using PBLLibrary;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Components
{
    internal class EmailManager
    {
        private SmtpClient _Client;

        public EmailManager()
        {
            _Client = new SmtpClient();

            _Client.Host = "smtp.gmail.com";
            _Client.Port = 587;

            _Client.UseDefaultCredentials = false;
            _Client.Credentials = new NetworkCredential(GlobalConfig.Instance.ConnectionString("Email"),
                GlobalConfig.Instance.ConnectionString("Password"));

            _Client.EnableSsl = true;

        }

        public void SendMessage(string desEmail, string subject, string body)
        {
            MailMessage message = new MailMessage();

            message.From = new MailAddress(GlobalConfig.Instance.ConnectionString("Email"));
            message.To.Add(new MailAddress(desEmail));
            message.Subject = subject;
            message.Body = body;

            _Client.Send(message);
        }
    }
}
