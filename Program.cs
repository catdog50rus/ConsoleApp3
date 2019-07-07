using System;

namespace ConsoleApp3
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            var user1 = new Users("catdog", "123");
            Console.WriteLine($"Login: {user1.NicName}");
            Console.WriteLine($"Password: {user1.Pass}");

            var client1 = new Client(user1.NicName, 3000);
            client1.Put(500);
            Console.WriteLine($"{client1.Name} CurrentSum: {client1.CurrentSum}");
            client1.Withdraw(600);
            Console.WriteLine($"{client1.Name} CurrentSum: {client1.CurrentSum}");

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
