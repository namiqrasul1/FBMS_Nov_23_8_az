using AdapterPattern.Services.MailServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class ControlPanel
    {
        private readonly IMailService _mailService;

        public ControlPanel(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void Confirmation()
        {
            // token generate olur
            _mailService.ConfirmMail("user@mail.com", "akjhsdjkasdh");
        }

        public void Checkout()
        {
            // alish alqoritmi

            _mailService.SendMail("user@mail.com", "Alish-verish melumati" ,"invoice");
        }
    }
}
