using System.Text.Json;
namespace RestaurangApp;


class FileHandler
{
    public string dataDir;
    public string userData;
    public string menuData;

    public FileHandler()
    {
        dataDir = Path.Combine(Directory.GetCurrentDirectory(), "data");
        userData = Path.Combine(dataDir, "Userdata.json");
        menuData = Path.Combine(dataDir, "Menudata.json");
    }

    public void LoadUser(List<User> staffList)
    {
        if (File.Exists(userData))
        {
            string loadUsers = File.ReadAllText(userData);
            if (!string.IsNullOrWhiteSpace(loadUsers))
            {
                var loadedUsers = JsonSerializer.Deserialize<List<User>>(loadUsers, new JsonSerializerOptions { IncludeFields = true });
                if (loadedUsers != null)
                {
                    staffList.Clear();
                    staffList.AddRange(loadedUsers);
                }
            }
        }
    }

    public void SaveUser(List<User> staffList)
    {
        string saveUsers = JsonSerializer.Serialize(staffList, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
        File.WriteAllText(userData, saveUsers);
    }

    public void LoadMenu(List<MenuItems> menu_List)
    {
        if (File.Exists(menuData))
        {
            string loadMenu = File.ReadAllText(menuData);
            if (!string.IsNullOrWhiteSpace(loadMenu))
            {
                var loadedMenu = JsonSerializer.Deserialize<List<MenuItems>>(loadMenu, new JsonSerializerOptions { IncludeFields = true });
                if (loadedMenu != null)
                {
                    menu_List.Clear();
                    menu_List.AddRange(loadedMenu);
                }
            }
        }
    }

}