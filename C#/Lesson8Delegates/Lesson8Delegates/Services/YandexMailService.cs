using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Delegates.Services
{
    internal class YandexMailService : IMailService
    {
        public void SendMail(string to, string subject, string body)
        {
            string from = "namiq_rasul@itstep.org";
            string pass = "hakunamatata";
            // yandex server request
        }
    }
}
