using System.Text.Json;
namespace RestaurangApp;


class FileHandler
{
    public string dataDir;
    public string userData;

    public FileHandler()
    {
        dataDir = Path.Combine(Directory.GetCurrentDirectory(), "data");
        userData = Path.Combine(dataDir, "Userdata.json");
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

}