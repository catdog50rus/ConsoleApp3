using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Client : Users, IAccount, IClient
    {
        int _sum;

        public int CurrentSum { get { return _sum; } }

        public string Name { get; set; }

        public string Roll { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Client(string nicName, string pass, string name, int sum, string roll, string email, int age) : base (nicName, pass)
        {
            Name = name;
            _sum = sum;
            Roll = roll;
            Email = email;
            Age = age;
        }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
    }
}
