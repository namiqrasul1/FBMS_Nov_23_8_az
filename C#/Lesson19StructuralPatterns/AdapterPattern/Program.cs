using AdapterPattern;
using AdapterPattern.Services.MailServices;
using StepMailService;

var stepservice = new StepEmailService();
IMailService step = new StepEmailServiceAdapter(stepservice);
IMailService mailService = new GmailService();

var controlPanel = new ControlPanel(step);

controlPanel.Confirmation();
controlPanel.Checkout();