using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IClientAccount : IAccount, IClient
    {
        void GetIncom(); 
    }
}
