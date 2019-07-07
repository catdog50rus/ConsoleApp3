using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class User
    {
        public string Roll { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public User(string roll, string email, int age)
        {
            Roll = roll;
            Email = email;
            Age = age;
        }
    }
}
