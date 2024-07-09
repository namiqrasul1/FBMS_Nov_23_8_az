using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Services.MailServices
{
    internal interface IMailService
    {
        void ConfirmMail(string mail, string token);
        void SendMail(string to, string subject, string body);
        bool CheckMail(string mail);
    }
}
