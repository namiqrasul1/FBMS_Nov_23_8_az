//using System.Timers;
//using MyTimer = System.Timers.Timer;
//class Program
//{
//    delegate void MyDelegate();
//    static event MyDelegate MyEvent;

//    static void Main(string[] args)
//    {
//        MyEvent = () => Console.WriteLine("Event Invoked");
//        MyEvent.Invoke();

//        //var timer = new MyTimer();
//        var timer = new System.Timers.Timer();
//        timer.Interval = 1000;
//        timer.Elapsed += Timer_Elapsed;
//        timer.Enabled = true;
//        timer.Start();

//        Console.ReadKey();
//    }

//    private static void Timer_Elapsed(object? sender, ElapsedEventArgs e)
//    {
//        Console.WriteLine("Hello World");
//    }
//}


namespace Lesson15Events
{
    class StepUpdateService
    {
        public delegate void UpdateHandler(object? sender, string text);
        public event UpdateHandler Published = (s, t) => { };

        public void Publish(string text)
        {
            Published.Invoke("STEP IT", text);
        }
    }

    class Email
    {
        public void GetEmail(object? sender, string text)
        {
            Console.WriteLine("You have new email");
            Console.WriteLine($"From: {sender}");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Body: {text}");
        }
    }

    class MobileApp
    {
        public void Notification(object? sender, string text)
        {
            Console.Beep(500, 900);
            Console.Beep(900, 200);
            Console.WriteLine($"Sender: {sender}: {text}");
        }
    }

    class Sms
    {
        public void GetSms(object? sender, string text)
        {
            Console.WriteLine($"New sms: {sender} : {text}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //var updateService = new StepUpdateService();
            //var email = new Email();
            //var mobile = new MobileApp();
            //var sms = new Sms();

            //var emailActive = false;
            //var mobileActive = false;
            //var smsActive = false;
            //int ch = 0;
            //while (ch != 5)
            //{
            //    Console.Clear();
            //    Console.WriteLine("1. Publish Something");
            //    Console.WriteLine($"2. Email: {(emailActive ? "Unsubscribe" : "Subscribe")}");
            //    Console.WriteLine($"3. Sms: {(smsActive ? "Unsubscribe" : "Subscribe")}");
            //    Console.WriteLine($"4. Mobile: {(mobileActive ? "Unsubscribe" : "Subscribe")}");

            //    ch = Console.ReadKey().KeyChar;

            //    switch (ch)
            //    {
            //        case '1': 
            //            Console.Clear();
            //            Console.WriteLine("Write Text:");
            //            var text = Console.ReadLine();
            //            updateService.Publish(text!);

            //            Console.ReadKey();
            //            break;

            //        case '2':
            //            if (!emailActive)
            //                updateService.Published += email.GetEmail;
            //            else
            //                updateService.Published -= email.GetEmail;
            //            emailActive = !emailActive;
            //            break;
            //        case '3':
            //            if (!smsActive)
            //                updateService.Published += sms.GetSms;
            //            else 
            //                updateService.Published -= sms.GetSms;
            //            smsActive = !smsActive;
            //            break;
            //        case '4':
            //            if (!mobileActive)
            //                updateService.Published += mobile.Notification;
            //            else 
            //                updateService.Published -= mobile.Notification;
            //            mobileActive = !mobileActive;
            //            break;
            //        default:
            //            break;
            //    }
            //}


            string[] strings = ["hakuna", "matata", "john", "doe"];
            var random = new Random();

            List<int> ints = new List<int>();
            random.Shuffle(strings);

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}