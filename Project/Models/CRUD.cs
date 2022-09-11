using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Project.Models
{
    class CRUD
    {
         public static List<User> GetInfoUser()
        {
            List<User> users = new List<User>();
            using (StreamReader sr= new StreamReader ("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\users.json"))
            {
                users = JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());
            }
            return users;
        }
        public static List<User> WriterUser(List<User>users)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\users.json"))
            {
                sw.Write(JsonConvert.SerializeObject(users));
            }
            return users;
        }
        public static List<Product> GetInfoProduct()
        {
            List<Product> products = new List<Product>();
            using (StreamReader sr = new StreamReader("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            }
            return products;
        }
        public static List<Product> WriterProduct(List<Product> products)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
            {
                sw.Write(JsonConvert.SerializeObject(products));
            }
            return products;
        }

        public static void PrintProduct()
        {
            List<Product> products;
            using (StreamReader sr = new StreamReader("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            }
            foreach (Product item in products)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Inqredint+" "+item.Price);
                
            }
        }
        public static List<User> UserDelete( int id)
        {
            List<User> users = GetInfoUser();
            users.Remove(users.SingleOrDefault(x => x.Id == id));
            CRUD.WriterUser(users);
            return users;
        }
        public static List<User> UpdateUser( bool value,int id)
        {
            List<User> users = GetInfoUser();
            User olduser = users.Find(x => x.Id == id);
            if (olduser==null)
            {
                Console.WriteLine("Bele bir Id tapilmadi");
                return users;
            }
            int id1 = olduser.Id;
            CRUD.UserDelete(olduser.Id);
            if (olduser.isAdmin == true)
            {
                olduser.isAdmin = false;
            }
            else if (olduser.isAdmin==false)
            {
                olduser.isAdmin = true;
            }
            users.Add(olduser);
            CRUD.WriterUser(users);
            return users;
           
        }
    }
}
