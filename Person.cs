using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Person : ISchool, IUniversity
    {
        void ISchool.Study()
        {
            Console.WriteLine("Учеба в школе");

        }
        void IUniversity.Study()
        {
            Console.WriteLine("Учеба в университете");

        }
    }
}
