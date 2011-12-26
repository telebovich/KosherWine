using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KosherWine.Email
{
    public interface IMailer
    {
        void SendMail(string from, string to, string subject, string body);
    }
}
