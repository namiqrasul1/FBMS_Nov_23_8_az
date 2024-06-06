using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Delegates.Services
{
    internal interface IMailService
    {
        void SendMail(string to, string subject, string body);
    }
}
