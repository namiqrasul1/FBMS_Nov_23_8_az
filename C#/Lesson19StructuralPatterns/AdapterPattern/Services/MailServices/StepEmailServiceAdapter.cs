using StepMailService;

namespace AdapterPattern.Services.MailServices
{
    internal class StepEmailServiceAdapter : IMailService
    {
        private readonly StepEmailService _stepEmailService;

        public StepEmailServiceAdapter(StepEmailService stepEmailService)
        {
            _stepEmailService = stepEmailService;
        }

        public bool CheckMail(string mail)
        {
            return _stepEmailService.StepCheckMail(mail);
        }

        public void ConfirmMail(string mail, string token)
        {
            _stepEmailService.StepConfirmMail(mail, token);
        }

        public void SendMail(string to, string subject, string body)
        {
            _stepEmailService.StepSendMail(to, subject, body);
        }
    }
}
