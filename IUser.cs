namespace RestaurangApp;

interface IUser
{

    public bool IsRole(Role role);

    public Role GetRole();

    public bool TryLogin(string username, string password);

}

enum Role
{
    None,
    Admin,
    HeadWaiter,
    Waiter,
    HeadChef,
    Chef,
}