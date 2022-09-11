using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project.Models
{
    class ProductCrud
    {
        public static void Add()
        {
            string name = Console.ReadLine();
            string inqredint = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());
            List<Product> products = new List<Product>();
            products.Add(new Product {Name=name,Inqredint=inqredint,Price=price});
            using (StreamWriter sw = new StreamWriter("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
            {
                sw.Write(JsonConvert.SerializeObject(products));
            }
        }
     
    }
}
