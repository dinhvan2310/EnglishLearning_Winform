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
            // Create a new SmtpClient object
            _Client = new SmtpClient();

            // Set the SMTP server address and port number
            _Client.Host = "smtp.gmail.com";
            _Client.Port = 587;

            //Set the username and password for the SMTP server(if required)
            _Client.UseDefaultCredentials = false;
            _Client.Credentials = new NetworkCredential(GlobalConfig.Instance.ConnectionString("Email"),
                GlobalConfig.Instance.ConnectionString("Password"));

            // Enable SSL encryption (if required)
            _Client.EnableSsl = true;

        }

        public void SendMessage(string desEmail, string subject, string body)
        {
            MailMessage message = new MailMessage();

            // Set the sender, recipient, subject, and body of the message
            message.From = new MailAddress(GlobalConfig.Instance.ConnectionString("Email"));
            message.To.Add(new MailAddress(desEmail));
            message.Subject = subject;
            message.Body = body;

            // Send the message
            _Client.Send(message);
        }
    }
}
