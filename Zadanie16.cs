using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Linq;


namespace ConsoleApp26
{
    class Zadanie16
    {
        public static object ItemPrice { get; private set; }

        static void Main(string[] args)
        {
            Item[] ItemArray = new Item[5];
            Item[] RestoredItemArray = new Item[5];
            string jsonString = "{\"ItemCode\":1, \"ItemName\":\"tovar\", \"ItemPrice\":500}";
            Item item = JsonSerializer.Deserialize<Item>(jsonString);

            for (int i = 0; i < 5; i++)
            {
                ItemArray[i] = new Item();
                Console.WriteLine("Введите значение «Код товара» для товара №{0}", i + 1);
                ItemArray[i].ItemCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение «Наименование товара» для товара №{0}", i + 1);
                ItemArray[i].ItemName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите значение «Цена товара» для товара №{0}", i + 1);
                ItemArray[i].ItemPrice = Convert.ToInt32(Console.ReadLine());

            }
            string jsonString = JsonSerializer.Serialize<Item>(jsonString);
            System.IO.File.WriteAllText(@"C:Products.json", jsonString);

            using (FileStream fs = new FileStream(@"C:Products.json", FileMode.Open))
            {
                Item restoredItem = JsonSerializer.Deserialize<Item>(jsonString);
                for (int i = 0; i < 5; i++)
                {
                    RestoredItemArray[i] = ItemArray[i].ItemPrice;

                }

            }
            int max = 0;
            
            for (int i = 0; i < RestoredItemArray.Length; i++)
            {
                
                if (ItemPrice.RestoredItemArray[i] > max)
                {
                    max = RestoredItemArray[i];
                }
            }
        }
        class Item
        {
            public int ItemCode { get; set; }
            public string ItemName { get; set; }
            public int ItemPrice { get; set; }

            public static implicit operator int(Item v)
            {
                throw new NotImplementedException();
            }
        }
    }
}

