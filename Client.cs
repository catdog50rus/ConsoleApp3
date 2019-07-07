using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Client : IAccount, IClient
    {
        int _sum;

        public int CurrentSum { get { return _sum; } }

        public string Name { get; set; }

        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
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
