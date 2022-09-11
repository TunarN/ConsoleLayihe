using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    class User
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public User()
        {
            _id++;
            Id = _id;
        }
    }   
}
