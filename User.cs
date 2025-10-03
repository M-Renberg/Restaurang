namespace RestaurangApp;

class User : IUser
{

    public string Username;
    string _password;
    public List<StaffContactInfo> staffInfo = new List<StaffContactInfo>();

    public User(string username, string password)
    {
        Username = username;
        _password = password;

    }
    
    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }

    public bool IsRole(Role role)
    {
        return Role.None == role;
    }

    public Role GetRole()
    {
        return Role.None;
    }
}