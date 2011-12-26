using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Mail;
using KosherWine.Logging;

namespace KosherWine.Email
{
    public class Mail: IMailer 
    {
        public void SendMail(string from, string to, string subject, string body)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(from);
            message.To.Add(new MailAddress(to));
            message.Subject = subject;
            message.Body = body;
            SmtpClient client = new SmtpClient();
            client.Send(message);

            Logger.Log.Info("Email message sent");
        }
    }
}