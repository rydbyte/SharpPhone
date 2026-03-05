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

        private static List<SmartPhone> phoneList = new List<SmartPhone>();
        public static IReadOnlyList<SmartPhone> PhoneList => phoneList;

        public SmartPhone() { }

        public SmartPhone(string Brand, string Model, int Size, double Price, int Stock, bool Save)
        {
            this.id = phoneList.Count + 1;
            this.brand = Brand;
            this.model = Model;
            this.size = Size;
            this.price = Price;
            this.stock = Stock;

            AddPhone(this);

            if (Save)
            {
                string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions
                {
                    WriteIndented = false,
                    IncludeFields = true
                });

                string formatted = $"{id} = {jsonString}\n";
                File.AppendAllText("C:\\Users\\ryanl\\source\\repos\\SharpPhone\\phones.json", formatted);
            }
        }

        public static void AddPhone(SmartPhone phone)
        {
            phoneList.Add(phone);
        }

        public static void DeletePhone(int id)
        {
            phoneList.RemoveAll(p => p.id == id);
            using (StreamWriter writer = new StreamWriter("C:\\Users\\ryanl\\source\\repos\\SharpPhone\\phones.json", false))
            {
                foreach (SmartPhone phone in phoneList)
                {
                    string jsonString = JsonSerializer.Serialize(phone, new JsonSerializerOptions
                    {
                        WriteIndented = false,
                        IncludeFields = true
                    });

                    writer.WriteLine($"{phone.id} = {jsonString}");
                }
            }
        }
        public static void ModifyPhone(int id, TextBox brand, TextBox model, TextBox size, TextBox price, TextBox stock)
        {
            phoneList[id].brand = brand.Text;
            phoneList[id].model = model.Text;
            phoneList[id].size = int.Parse(size.Text);
            phoneList[id].price = double.Parse(price.Text);
            phoneList[id].stock = int.Parse(stock.Text);
            using (StreamWriter writer = new StreamWriter("C:\\Users\\ryanl\\source\\repos\\SharpPhone\\phones.json", false))
            {
                foreach (SmartPhone phone in phoneList)
                {
                    string jsonString = JsonSerializer.Serialize(phone, new JsonSerializerOptions
                    {
                        WriteIndented = false,
                        IncludeFields = true
                    });

                    writer.WriteLine($"{phone.id} = {jsonString}");
                }
            }
        }

        public static IReadOnlyList<SmartPhone> GetList()
        {
            return phoneList;
        }

        public static void LoadFromFile(string path)
        {
            if (!File.Exists(path))
                return;

            string[] lines = File.ReadAllLines(path);
            phoneList.Clear();

            foreach (string rawLine in lines)
            {
                string line = rawLine.Trim();
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                int equalsIndex = line.IndexOf('=');
                if (equalsIndex == -1)
                    continue;

                string jsonPart = line.Substring(equalsIndex + 1).Trim();

                try
                {
                    SmartPhone? phone = JsonSerializer.Deserialize<SmartPhone>(jsonPart, new JsonSerializerOptions
                    {
                        IncludeFields = true
                    });

                    if (phone != null)
                        phoneList.Add(phone);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error reading phone entry:\n{line}\n\n{ex.Message}",
                        "JSON Parse Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
