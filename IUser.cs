namespace RestaurangApp;

interface IUser
{

    public bool IsRole(Role role);

    public Role GetRole();

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