using System.ComponentModel.Design;
using RestaurangApp;

FileHandler fh = new FileHandler();

List<User> staffList = new List<User>();

//test admin
User Admin = new User("admin", "admin");
staffList.Add(Admin);
Admin.GetRole();

fh.LoadUser(staffList);

User? activeUser = null; 
bool running = true;

while (running)
{

    if (activeUser == null)
    {
        System.Console.WriteLine("Restaurang Management System:");
        System.Console.WriteLine(" ");

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
                    if (user.TryLogin(loginUsername, loginPassword))
                    {
                        activeUser = user;
                        break;
                    }
                }


                break;
            default:
                System.Console.WriteLine("Wrong input. Please try again");
                break;
        }
    }

    else
    {
        
        
    }

}