namespace RestaurangApp;

class User : IUser
{

    public string? Username;
    public string? _password;
    public List<StaffContactInfo> staffInfo = new List<StaffContactInfo>();
    public Role Role;

    public User() { }

    public User(string username, string password, Role role = Role.None)
    {
        Username = username;
        _password = password;
        Role = role;

    }

    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }

    public bool IsRole(Role role)
    {
        return Role == role;
    }

    static public void AddUser(List<User> staffList)
    {

        System.Console.WriteLine("Create new staff member:");
        System.Console.WriteLine(" ");
        System.Console.WriteLine("First name: ");
        string? NuFNameInput = Console.ReadLine();
        System.Console.WriteLine("Last name: ");
        string? NuLNameInput = Console.ReadLine();
        System.Console.WriteLine("Social security number: ");
        System.Console.WriteLine("Writen as YYMMDD");
        int NuBirthdayInput = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Adress:");
        string? NuAdressInput = Console.ReadLine();
        System.Console.WriteLine("Email:");
        string? NuEmailInput = Console.ReadLine();
        System.Console.WriteLine("Phone number");
        int NuPhoneNrInput = int.Parse(Console.ReadLine()!);

        string NuUsername = NuFNameInput + NuLNameInput;
        System.Console.WriteLine("Write a password:");
        string? NuPasswordInput = Console.ReadLine();

        System.Console.WriteLine("Select Staff Title:");
        System.Console.WriteLine("1. Head Chef");
        System.Console.WriteLine("2. Head Waiter");
        System.Console.WriteLine("3. Chef");
        System.Console.WriteLine("4. Waiter");

        string? NuRoleInput = Console.ReadLine();

        if (NuRoleInput == "1")
        {
            User newuser = new User(NuUsername, NuPasswordInput!, Role.HeadChef);
            newuser.staffInfo.Add(new StaffContactInfo(NuFNameInput!, NuLNameInput!, NuBirthdayInput, NuAdressInput!, NuEmailInput!, NuPhoneNrInput));
            staffList.Add(newuser);

            System.Console.WriteLine($"You have created a new staff member: {newuser.Username}");
            foreach (StaffContactInfo si in newuser.staffInfo)
            {
                System.Console.WriteLine(si);
            }
            Console.ReadLine();
        }
        if (NuRoleInput == "2")
        {
            User newuser = new User(NuUsername, NuPasswordInput!, Role.HeadWaiter);
            newuser.staffInfo.Add(new StaffContactInfo(NuFNameInput!, NuLNameInput!, NuBirthdayInput, NuAdressInput!, NuEmailInput!, NuPhoneNrInput));
            staffList.Add(newuser);

            System.Console.WriteLine($"You have created a new staff member: {newuser.Username}");
            foreach (StaffContactInfo si in newuser.staffInfo)
            {
                System.Console.WriteLine(si);
            }
            Console.ReadLine();
        }
        if (NuRoleInput == "3")
        {
            User newuser = new User(NuUsername, NuPasswordInput!, Role.Chef);
            newuser.staffInfo.Add(new StaffContactInfo(NuFNameInput!, NuLNameInput!, NuBirthdayInput, NuAdressInput!, NuEmailInput!, NuPhoneNrInput));
            staffList.Add(newuser);

            System.Console.WriteLine($"You have created a new staff member: {newuser.Username}");
            foreach (StaffContactInfo si in newuser.staffInfo)
            {
                System.Console.WriteLine(si);
            }
            Console.ReadLine();
        }
        if (NuRoleInput == "4")
        {
            User newuser = new User(NuUsername, NuPasswordInput!, Role.Waiter);
            newuser.staffInfo.Add(new StaffContactInfo(NuFNameInput!, NuLNameInput!, NuBirthdayInput, NuAdressInput!, NuEmailInput!, NuPhoneNrInput));
            staffList.Add(newuser);

            System.Console.WriteLine($"You have created a new staff member: {newuser.Username}");
            foreach (StaffContactInfo si in newuser.staffInfo)
            {
                System.Console.WriteLine(si);
            }
            Console.ReadLine();
        }
        else
        {
            System.Console.WriteLine("Something went wrong. Please try again");
        }
    }
}