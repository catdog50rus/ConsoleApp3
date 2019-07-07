using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Users
    {
        public string NicName { get; set; }
        public string Pass { get; set; }

        public Users(string nicName, string pass)
        {
            NicName = nicName;
            Pass = pass;
        }
    }


}
