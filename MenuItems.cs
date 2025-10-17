namespace RestaurangApp;


class MenuItems
{
    public string TitleName;
    public string ItemDescription;
    public int Price;

    public TypeOfItem ItemType;

    public enum TypeOfItem
    {
        None,
        Appetizers,
        Entrees,
        Side_Dish,
        Desserts,
        Specials,
        Beverages,
    }

    public MenuItems(string title, string description, int price, TypeOfItem typeofitem)
    {
        TitleName = title;
        ItemDescription = description;
        Price = price;

        ItemType = TypeOfItem.None;

    }

}