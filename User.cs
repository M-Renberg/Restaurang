namespace RestaurangApp;

class User
{

    public string Username;
    string _password;
    public List<StaffContactInfo> staffInfo = new List<StaffContactInfo>();

    public User(string username, string password)
    {
        Username = username;
        _password = password;

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