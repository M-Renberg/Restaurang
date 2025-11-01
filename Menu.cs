using System.Runtime.CompilerServices;

namespace RestaurangApp;

class Menu
{

    public Menu()
    {

    }

    public void ShowMenu()
    {
        Console.Clear();
        System.Console.WriteLine("Restaurang Menu:");
        System.Console.WriteLine(" ");
        System.Console.WriteLine("[1] Appatizers");
        System.Console.WriteLine("[2] Entrees");
        System.Console.WriteLine("[3] Side Dishes");
        System.Console.WriteLine("[4] Desserts");
        System.Console.WriteLine("[5] Tonight Specials");
        System.Console.WriteLine("[6] Drink Menu");
        System.Console.WriteLine(" ");
        System.Console.WriteLine("[9] Back");
        switch (Console.ReadLine())
        {
            case "1": //Appatizers
                break;
            case "2": //Entrees
                break;
            case "3": //Side_Dish
                break;
            case "4": //Desserts
                break;
            case "5": //Specials
                break;
            case "6": //Beverages
                break;
            case "7": //empty
                break;
            case "8": //empty
                break;
            case "9": //back options
                break;
            default:
            System.Console.WriteLine("Invalide choice");
                break;

        }
    }
    
    public void HandleMenuItems(List<MenuItems> menu_List)
    {
        Console.Clear();
        System.Console.WriteLine("Menu Handler:");
        System.Console.WriteLine("[1] Add menu item");
        System.Console.WriteLine("[2] Remove menu item");
        System.Console.WriteLine("[3] Back");

        switch (Console.ReadLine())
        {
            case "1":
                System.Console.WriteLine("Add a menu Item:");
                System.Console.WriteLine(" ");
                System.Console.WriteLine("What type of Item would you like to add:");
                System.Console.WriteLine("[1] Appatizers");
                System.Console.WriteLine("[2] Entrees");
                System.Console.WriteLine("[3] Side Dishes");
                System.Console.WriteLine("[4] Desserts");
                System.Console.WriteLine("[5] Tonight Specials");
                System.Console.WriteLine("[6] Drink Menu");
                switch (Console.ReadLine())
                {
                    case "1": //Appatizers
                        System.Console.WriteLine("Your have select Appatizers:");
                        System.Console.WriteLine("What would you like to name it?");
                        string? AppatizersTitleInput = Console.ReadLine();
                        System.Console.WriteLine("Write a description of the itemm:");
                        string? AppatizersDescriptionInput = Console.ReadLine();
                        System.Console.WriteLine("What price would you like to set for the item?");
                        string? AppatizersPriceInput = Console.ReadLine();
                        int.TryParse(AppatizersPriceInput, out int AppatizersPriceInt);

                        System.Console.WriteLine($"You have named the dish: {AppatizersTitleInput}");
                        System.Console.WriteLine($"With description: {AppatizersDescriptionInput}");
                        System.Console.WriteLine($"With price: {AppatizersPriceInput}");

                        System.Console.WriteLine("Are you satified with this?");
                        System.Console.WriteLine("[Y/N]");
                        string? AppatizersYNInput = Console.ReadLine();
                        if (AppatizersYNInput == "y")
                        {
                            menu_List.Add(new MenuItems(AppatizersTitleInput!, AppatizersDescriptionInput!, AppatizersPriceInt, MenuItems.TypeOfItem.Appetizers));
                        }
                        else if (AppatizersYNInput == "n")
                        {
                            break;      
                        }
                        else
                        {
                            System.Console.WriteLine("Something went wrong");
                        }

                    break;
                    case "2": //Entrees
                    System.Console.WriteLine("Your have select Appatizers:");
                        System.Console.WriteLine("What would you like to name it?");
                        string? EntreesTitleInput = Console.ReadLine();
                        System.Console.WriteLine("Write a description of the itemm:");
                        string? EntreesDescriptionInput = Console.ReadLine();
                        System.Console.WriteLine("What price would you like to set for the item?");
                        string? EntreesPriceInput = Console.ReadLine();
                        int.TryParse(EntreesPriceInput, out int EntreesPriceInt);

                        System.Console.WriteLine($"You have named the dish: {EntreesTitleInput}");
                        System.Console.WriteLine($"With description: {EntreesDescriptionInput}");
                        System.Console.WriteLine($"With price: {EntreesPriceInput}");

                        System.Console.WriteLine("Are you satified with this?");
                        System.Console.WriteLine("[Y/N]");
                        string? EntreesYNInput = Console.ReadLine();
                        if (EntreesYNInput == "y")
                        {
                            menu_List.Add(new MenuItems(EntreesTitleInput!, EntreesDescriptionInput!, EntreesPriceInt, MenuItems.TypeOfItem.Entrees));
                        }
                        else if (EntreesYNInput == "n")
                        {
                            break;      
                        }
                        else
                        {
                            System.Console.WriteLine("Something went wrong");
                        }
                    break;
                    case "3": //Side_Dish
                    System.Console.WriteLine("Your have select Appatizers:");
                        System.Console.WriteLine("What would you like to name it?");
                        string? SDTitleInput = Console.ReadLine();
                        System.Console.WriteLine("Write a description of the itemm:");
                        string? SDDescriptionInput = Console.ReadLine();
                        System.Console.WriteLine("What price would you like to set for the item?");
                        string? SDPriceInput = Console.ReadLine();
                        int.TryParse(SDPriceInput, out int SDPriceInt);

                        System.Console.WriteLine($"You have named the dish: {SDTitleInput}");
                        System.Console.WriteLine($"With description: {SDDescriptionInput}");
                        System.Console.WriteLine($"With price: {SDPriceInput}");

                        System.Console.WriteLine("Are you satified with this?");
                        System.Console.WriteLine("[Y/N]");
                        string? SDYNInput = Console.ReadLine();
                        if (SDYNInput == "y")
                        {
                            menu_List.Add(new MenuItems(SDTitleInput!, SDDescriptionInput!, SDPriceInt, MenuItems.TypeOfItem.Side_Dish));
                        }
                        else if (SDYNInput == "n")
                        {
                            break;      
                        }
                        else
                        {
                            System.Console.WriteLine("Something went wrong");
                        }
                    break;
                    case "4": //Desserts
                    System.Console.WriteLine("Your have select Appatizers:");
                        System.Console.WriteLine("What would you like to name it?");
                        string? DessertsTitleInput = Console.ReadLine();
                        System.Console.WriteLine("Write a description of the itemm:");
                        string? DessertsDescriptionInput = Console.ReadLine();
                        System.Console.WriteLine("What price would you like to set for the item?");
                        string? DessertsPriceInput = Console.ReadLine();
                        int.TryParse(DessertsPriceInput, out int DessertsPriceInt);

                        System.Console.WriteLine($"You have named the dish: {DessertsTitleInput}");
                        System.Console.WriteLine($"With description: {DessertsDescriptionInput}");
                        System.Console.WriteLine($"With price: {DessertsPriceInput}");

                        System.Console.WriteLine("Are you satified with this?");
                        System.Console.WriteLine("[Y/N]");
                        string? DessertsYNInput = Console.ReadLine();
                        if (DessertsYNInput == "y")
                        {
                            menu_List.Add(new MenuItems(DessertsTitleInput!, DessertsDescriptionInput!, DessertsPriceInt, MenuItems.TypeOfItem.Appetizers));
                        }
                        else if (DessertsYNInput == "n")
                        {
                            break;      
                        }
                        else
                        {
                            System.Console.WriteLine("Something went wrong");
                        }
                    break;
                    case "5": //Specials
                    //menu combos
                    System.Console.WriteLine("WIP");
                    break;
                    case "6": //Beverages
                    System.Console.WriteLine("Your have select Appatizers:");
                        System.Console.WriteLine("What would you like to name it?");
                        string? BeveragesTitleInput = Console.ReadLine();
                        System.Console.WriteLine("Write a description of the itemm:");
                        string? BeveragesDescriptionInput = Console.ReadLine();
                        System.Console.WriteLine("What price would you like to set for the item?");
                        string? BeveragesPriceInput = Console.ReadLine();
                        int.TryParse(BeveragesPriceInput, out int BeveragesPriceInt);

                        System.Console.WriteLine($"You have named the dish: {BeveragesTitleInput}");
                        System.Console.WriteLine($"With description: {BeveragesDescriptionInput}");
                        System.Console.WriteLine($"With price: {BeveragesPriceInput}");

                        System.Console.WriteLine("Are you satified with this?");
                        System.Console.WriteLine("[Y/N]");
                        string? BeveragesYNInput = Console.ReadLine();
                        if (BeveragesYNInput == "y")
                        {
                            menu_List.Add(new MenuItems(BeveragesTitleInput!, BeveragesDescriptionInput!, BeveragesPriceInt, MenuItems.TypeOfItem.Appetizers));
                        }
                        else if (BeveragesYNInput == "n")
                        {
                            break;      
                        }
                        else
                        {
                            System.Console.WriteLine("Something went wrong");
                        }
                        break;
                    default:
                        System.Console.WriteLine("Something went wrong");
                        Console.ReadLine();
                        break;
                }

                break;
            case "2":

                System.Console.WriteLine("Remove Items from the Menu:");
                System.Console.WriteLine("[1] Food.");
                System.Console.WriteLine("[2] Drinks.");

                switch (Console.ReadLine())
                {
                    case "1":
                    for(int i = 0; i < menu_List.Count; i++)
                        {
                            if (menu_List[i].ItemType == MenuItems.TypeOfItem.Appetizers)
                            {
                                System.Console.WriteLine($"Item number {menu_List[i]}, Name: {menu_List[i].TitleName}, Description: {menu_List[i].ItemDescription}");
                            }
                            if (menu_List[i].ItemType == MenuItems.TypeOfItem.Entrees)
                            {
                                System.Console.WriteLine($"Item number {menu_List[i]}, Name: {menu_List[i].TitleName}, Description: {menu_List[i].ItemDescription}");
                            }
                            if (menu_List[i].ItemType == MenuItems.TypeOfItem.Side_Dish)
                            {
                                System.Console.WriteLine($"Item number {menu_List[i]}, Name: {menu_List[i].TitleName}, Description: {menu_List[i].ItemDescription}");
                            }
                            if (menu_List[i].ItemType == MenuItems.TypeOfItem.Desserts)
                            {
                                System.Console.WriteLine($"Item number {menu_List[i]}, Name: {menu_List[i].TitleName}, Description: {menu_List[i].ItemDescription}");
                            }
                            if (menu_List[i].ItemType == MenuItems.TypeOfItem.Specials)
                            {
                                System.Console.WriteLine($"Item number {menu_List[i]}, Name: {menu_List[i].TitleName}, Description: {menu_List[i].ItemDescription}");
                            }
                            
                            System.Console.WriteLine("Select the menu item you wish to delete:");
                            System.Console.Write("Write the item number:");
                            string? deleteInput = Console.ReadLine();
                            if (int.TryParse(deleteInput, out int deleteInputint))
                            {
                                menu_List.Remove(menu_List[deleteInputint]);
                                System.Console.WriteLine("The item has been removed");
                            }
                            else
                            {
                                System.Console.WriteLine("Something went wrong");
                                Console.ReadLine();
                                return;
                            }
                        }
                        break;
                    case "2":
                        for(int i = 0; i < menu_List.Count; i++)
                            {
                            if (menu_List[i].ItemType == MenuItems.TypeOfItem.Beverages)
                            {
                                System.Console.WriteLine($"Item number {menu_List[i]}, Name: {menu_List[i].TitleName}, Description: {menu_List[i].ItemDescription}");
                            }
                            System.Console.WriteLine("Select the menu item you wish to delete:");
                            System.Console.Write("Write the item number:");
                            string? deleteInput = Console.ReadLine();
                            if (int.TryParse(deleteInput, out int deleteInputint))
                            {
                                menu_List.Remove(menu_List[deleteInputint]);
                                System.Console.WriteLine("The item has been removed");
                            }
                            else
                            {
                                System.Console.WriteLine("Something went wrong");
                                Console.ReadLine();
                                return;
                            }
                            }
                        break;
                    default:
                        System.Console.WriteLine("Something went wrong");
                        break;
                }

                break;
            case "3":
                break;
            default:
                System.Console.WriteLine("Invalide choice");
                break;
        }

    }
}