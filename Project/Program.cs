using Newtonsoft.Json;
using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = CRUD.GetInfoUser();
            LoginMenu:
            Console.WriteLine("1)Login");
            Console.WriteLine("2)Register");
            int choise;
            int.TryParse(Console.ReadLine(), out choise);
            Console.Clear();
            Login:
            if (choise==1)
            {
                Console.WriteLine("Input your Username");
                string username = Console.ReadLine();
                Console.WriteLine("Input your Password");
                string password = Console.ReadLine();
             
                User user = users.Find(u => u.Username == username && u.Password == password);
                if (user==null)
                {
                    Console.WriteLine("Did not Find Username or Password Please try again");
                    goto Login;
                }
                Console.WriteLine($"Welcome {user.Name} {user.Surname}");
                goto UserMenu;
            }
            else if (choise==2)
            {
                UserCRUD.Registration(users);
                goto LoginMenu;
            }
            else
            {
                Console.WriteLine("Please Input Correctly");
                goto LoginMenu;
            }
            UserMenu:
            List<Product> products= CRUD.GetInfoProduct();
            Console.WriteLine("1)Look at the Pizzas");
            Console.WriteLine("2)Place an Order");
            int choise1;
            int.TryParse(Console.ReadLine(), out choise1);
            if (choise1==1)
            {
                CRUD.PrintProduct();
            }
            if (choise1==2)
            {
               
            }
            Console.WriteLine("Silmek istediyin userin id-ni daxil et");
            int id = int.Parse(Console.ReadLine());
            CRUD.UserDelete(id);



        }



    }
}
