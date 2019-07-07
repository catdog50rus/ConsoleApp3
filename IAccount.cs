using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }
}
