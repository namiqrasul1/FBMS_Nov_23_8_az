using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Services.MailServices
{
    internal class GmailService : IMailService
    {
        public bool CheckMail(string mail)
        {
            return true;
        }

        public void ConfirmMail(string mail, string token)
        {
            // send token to mail
            Console.WriteLine("GmailService Confirmation");
        }

        public void SendMail(string to, string subject, string body)
        {
            Console.WriteLine("GmailService maili gonderdi");
        }
    }
}
