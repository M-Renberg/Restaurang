using System.ComponentModel.Design;
using RestaurangApp;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

FileHandler fh = new FileHandler();

List<User> staffList = new List<User>();

fh.LoadUser(staffList);
//test admin
//User Admin = new User("admin", "admin", Role.Admin);
//staffList.Add(Admin);


User? activeUser = null; 
bool running = true;

while (running)
{

    if (activeUser == null)
    {
        Console.Clear();
        System.Console.WriteLine("Restaurang Management System:");
        System.Console.WriteLine(" ");
        System.Console.WriteLine("1. Login");
        System.Console.WriteLine("9. Quit program");

        string? inputLoginMenu = Console.ReadLine();

        switch (inputLoginMenu)
        {
            case "1":
                System.Console.WriteLine("Enter you username");
                string? loginUsername = Console.ReadLine();
                System.Console.WriteLine("Enter you password");
                string? loginPassword = Console.ReadLine();

                foreach (User user in staffList)
                {
                    if (user.TryLogin(loginUsername!, loginPassword!))
                    {
                        activeUser = user;
                        // System.Console.WriteLine($"du loggade in som {activeUser.Username} din roll är {activeUser.Role}");
                        // Console.ReadLine();
                        break;
                    }
                }
                break;
            case "2":
                break;
            case "9":
                running = false;
                break;
            default:
                System.Console.WriteLine("Wrong input. Please try again");
                break;
        }
    }



    else
    {
        if (activeUser.IsRole(Role.Admin))
        {
            Console.Clear();
            System.Console.WriteLine($"You're logged in as {activeUser.Username}");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("1. ");
            System.Console.WriteLine("2. Add a new staff member");
            System.Console.WriteLine("8. logout");
            System.Console.WriteLine("quit. Program shut down");
            string? menuInput = Console.ReadLine();

            switch (menuInput)
            {
                case "1":
                    break;
                case "2":
                    User.AddUser(staffList);
                    fh.SaveUser(staffList);
                    break;
                case "8":
                    System.Console.WriteLine("You have now logged out");
                    Console.ReadLine();
                    fh.SaveUser(staffList);
                    activeUser = null;
                    break;
                case "quit":
                    fh.SaveUser(staffList);
                    running = false;
                    break;
            }
        }
        else if (activeUser.IsRole(Role.HeadChef))
        {
            Console.Clear();
            System.Console.WriteLine($"You're logged in as {activeUser.Username}");

        }
        else if (activeUser.IsRole(Role.HeadWaiter))
        {
            Console.Clear();
            System.Console.WriteLine($"You're logged in as {activeUser.Username}");

        }
        else if (activeUser.IsRole(Role.Chef))
        {
            Console.Clear();
            System.Console.WriteLine($"You're logged in as {activeUser.Username}");

        }
        else if (activeUser.IsRole(Role.Waiter))
        {
            Console.Clear();
            System.Console.WriteLine($"You're logged in as {activeUser.Username}");

        }
        else
        {
            System.Console.WriteLine("Something went wrong.");
            Console.ReadLine();
        }

    }

}