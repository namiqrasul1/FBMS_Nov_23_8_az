using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepMailService
{
    public class StepEmailService
    {
        public bool StepCheckMail(string mail)
        {
            return true;
        }

        public void StepConfirmMail(string mail, string token)
        {
            // send token to mail
            Console.WriteLine("StepEmailService Confirmation");
        }

        public void StepSendMail(string to, string subject, string body)
        {
            Console.WriteLine("StepEmailService maili gonderdi");
        }
    }
}
