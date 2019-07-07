using System;

namespace ConsoleApp3
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            var client1 = new Client("catdog", "123", "Алексей", 3000, "client", "catdog50rus@gmail.com", 39);
            Console.WriteLine($"Role: {client1.Roll}");
            Console.WriteLine($"Name: {client1.Name}");
            Console.WriteLine($"CurrentSum: {client1.CurrentSum}");
            Console.WriteLine();

            client1.Put(500);
            Console.WriteLine($"{client1.Name} Put CurrentSum: {client1.CurrentSum}");
            client1.Withdraw(600);
            Console.WriteLine($"{client1.Name} WithDraw CurrentSum: {client1.CurrentSum}");
            Console.WriteLine();

            ISchool pupil = new Person();
            IUniversity student = new Person();
            pupil.Study();
            student.Study();

            Person person = new Person();
            ISchool p1 = person as ISchool;
            p1.Study();

            IUniversity p2 = person as IUniversity;
            p2.Study();


        }
    }

}
