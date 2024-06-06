using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Delegates.Services
{
    internal class GmailService : IMailService
    {
        public void SendMail(string to, string subject, string body)
        {
            string from = "namiq_rasul@gmail.com";
            string pass = "hakunamatata";
            // gmail server request
        }
    }
}
