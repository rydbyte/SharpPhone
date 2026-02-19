using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SharpPhone
{
    class SmartPhone
    {
        public int id;
        public string brand;
        public string model;
        public int size;
        public double price;
        public int stock;

        // Internal list (can be modified only inside this class)
        private static List<SmartPhone> phoneList = new List<SmartPhone>();

        // Public read-only access
        public static IReadOnlyList<SmartPhone> PhoneList => phoneList;

        public SmartPhone(string Brand, string Model, int Size, double Price, int Stock)
        {
            id = phoneList.Count + 1;
            brand = Brand;
            model = Model;
            size = Size;
            price = Price;
            stock = Stock;

            AddPhone(this);
            string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true, 
                IncludeFields = true
            });

            File.WriteAllText("C:\\Users\\ryanl\\source\\repos\\SharpPhone\\phones.json", jsonString);
            Console.WriteLine(File.ReadAllText("C:\\Users\\ryanl\\source\\repos\\SharpPhone\\phones.json"));
        }

        // Method to safely add a phone to the list
        public static void AddPhone(SmartPhone phone)
        {
            phoneList.Add(phone);
        }
        public static IReadOnlyList<SmartPhone> GetList()
        {
            return phoneList;
        }

    }
}
