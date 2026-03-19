using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace SharpPhone
{
    public class SmartPhone
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int size { get; set; }
        public double price { get; set; }
        public int stock { get; set; }

        public SmartPhone(string Brand, string Model, int Size, double Price, int Stock)
        {
            this.id = SharpPhoneDataBase.phoneList.Count;
            this.brand = Brand;
            this.model = Model;
            this.size = Size;
            this.price = Price;
            this.stock = Stock;

            SharpPhoneDataBase.phoneList.Add(this);

            JsonStore.Save();
        }
    }

    public class UserAccount
    {
        public string username { get; set; } = "";
        public string password { get; set; } = "";
        public int failedAttempts { get; set; } = 0;
        public bool locked { get; set; } = false;
        public UserAccount(string username, string password, int failedAttempts, bool locked) 
        { 
            this.username = username;
            this.password = password;
            this.failedAttempts = failedAttempts;
            this.locked = locked;

            SharpPhoneDataBase.userAccounts.Add(this);

            JsonStore.Save();
        }

    }

    public class JsonStore
    {
        public static void Load()
        {
            var path = @"C:\Users\ryanl\source\repos\SharpPhone\phones.json";
            if (!File.Exists(path)) return;

            var json = File.ReadAllText(path);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            if (root.TryGetProperty("phones", out var phones))
            {
                var phonesList = JsonSerializer.Deserialize<List<SmartPhone>>(phones.GetRawText());
                SharpPhoneDataBase.phoneList = phonesList ?? new List<SmartPhone>();
            }

            if (root.TryGetProperty("users", out var users))
            {
                var usersList = JsonSerializer.Deserialize<List<UserAccount>>(users.GetRawText());
                SharpPhoneDataBase.userAccounts = usersList ?? new List<UserAccount>();
            }
        }

        public static void Save()
        {
            var data = new
            {
                phones = SharpPhoneDataBase.phoneList,
                users = SharpPhoneDataBase.userAccounts
            };

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("C:\\Users\\ryanl\\source\\repos\\SharpPhone\\phones.json", json);
        }

        public static void Delete(int id)
        {
            SharpPhoneDataBase.phoneList.RemoveAll(p => p.id == id);
            Save();
        }
        public static void Modify(int id, TextBox brand, TextBox model, TextBox size, TextBox price, TextBox stock)
        {
            SharpPhoneDataBase.phoneList[id].brand = brand.Text;
            SharpPhoneDataBase.phoneList[id].model = model.Text;
            SharpPhoneDataBase.phoneList[id].size = int.Parse(size.Text);
            SharpPhoneDataBase.phoneList[id].price = double.Parse(price.Text);
            SharpPhoneDataBase.phoneList[id].stock = int.Parse(stock.Text);
            Save();
        }
    }

    public class SharpPhoneDataBase
    {
        public static List<SmartPhone> phoneList = new List<SmartPhone>();
        public static List<UserAccount> userAccounts = new List<UserAccount>();
    }
}
