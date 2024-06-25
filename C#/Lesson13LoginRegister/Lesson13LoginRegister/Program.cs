using Lesson13LoginRegister.Models;
using Lesson13LoginRegister.Services;

class Program
{
    public static void MainPage()
    {
        Console.Clear();
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
    }

    public static void LoginPage()
    {
        Login:
        Console.Clear();
        Console.WriteLine("Sign In");
        Console.WriteLine("Email:");
        var email = Console.ReadLine();
        Console.WriteLine("Password:");
        var password = Console.ReadLine();

        // yoxlamalar (validation)

        if (!UserManager.Login(email!, password!))
        {
            Console.WriteLine("Invalid email or password");
            Thread.Sleep(2000);
            goto Login;
        }
       

    }

    public static void RegisterPage()
    {
        Register:
        Console.Clear();
        Console.WriteLine("Sign Up");
        Console.WriteLine("Name:");
        var name = Console.ReadLine();
        Console.WriteLine("Email:");
        var email = Console.ReadLine();
        Console.WriteLine("Date of birth (dd.MM.yyyy):");
        var date = Console.ReadLine();
        Console.WriteLine("Password:");
        var password = Console.ReadLine();

        // validation

        try
        {
            UserManager.Register(name!, email!, password!, date!);
            Console.WriteLine("Registration successfully");
            Thread.Sleep(1000);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(2000);
            goto Register;
        }
    }

    static void Main(string[] args)
    {
        #region Null coalising operator

        //List<string>? FromAnotherAssembly() { return null; }

        //List<string>? ints = FromAnotherAssembly();


        //ints = ints ?? new List<string>();
        //ints ??= new List<string>();
        //int a = 42;
        //a = a + 2;
        //a += 2;

        //ints?.Add("12");

        //string s = null;
        //ints.Add(s ?? "kamil");
        //Console.WriteLine("Hello, World!");


        //string s = "hakuna";

        //Console.WriteLine(s ?? "kamil");

        #endregion


        //Guid guid = Guid.NewGuid();
        //guid.
        //Console.WriteLine(guid.ToString());

        //if(Login("email", "pass"))
        //{
        //    Console.WriteLine($"Welcome, {User.Name}");
        //}

        while (true)
        {
            if (UserManager.User is null)
            {
                MainPage();
                var choice = Console.ReadLine();
                switch(choice)
                {
                    case "1": LoginPage(); break;
                    case "2": RegisterPage(); break;
                }
            }
            else
            {
                Console.WriteLine($"Welcome, {UserManager.User.Name}");

                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Backspace)
                    UserManager.Logout();

            }
        }



    }
}



