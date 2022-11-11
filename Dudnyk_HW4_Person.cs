using System;
using System.Collections.Generic;

namespace Dudnyk_HW4
{
    class Person
    {
        string name;
        DateTime birthDate;

        public Person(string name, int birthDay, int birthMonth, int birthYear)
        {
            this.name = name;
            birthDate = new DateTime(birthYear, birthMonth, birthDay);

        }

        public Person()
        {
            name = "";
            birthDate = new DateTime(1, 1, 1);
        }

        public void Input()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your birth day, month a year, press \"Enter\" after each input: ");
            int tempDay = Convert.ToInt32(Console.ReadLine());
            int tempMonth = Convert.ToInt32(Console.ReadLine());
            int tempYear = Convert.ToInt32(Console.ReadLine());

            birthDate = new DateTime(tempYear, tempMonth, tempDay);
        }

        public override string ToString()
        {
            return $"DOSSIER\n-------\nName: {name}\nDate of birth: {birthDate.ToString()}\n\n";
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public int Age()
        {
            var now = DateTime.Now;
            TimeSpan age = now - birthDate;
            return age.Days / 365;
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public static bool operator ==(Person lhs, Person rhs)
        {
            return (lhs.name == rhs.name) && (lhs.birthDate == rhs.birthDate);
        }

        public static bool operator !=(Person lhs, Person rhs)
        {
            return !(lhs == rhs);
        }
    }



   
    
    class Program
    {
        static void Main()
        {
            var stan = new Person("Stan Marsh", 4, 11, 1976);
            var keny = new Person("Keny McKormick", 3, 2, 1975);
            var kyle = new Person("Kyle Broflowski", 24, 4, 1975);
            var butters = new Person("Butters", 6, 7, 1974);
            var eric = new Person("Eric Cartman", 30, 3, 1974);
            var mrSlave = new Person("Mr. Slave", 23, 8, 1960);


            List<Person> vec = new List<Person> {stan, keny, kyle, butters, eric, mrSlave};

            foreach (var guy in vec)
                Console.WriteLine(guy);

            foreach (var guy in vec)
            {
                if (guy.Age() < 50)
                    guy.ChangeName("To young");
            }

            foreach (var guy in vec)
                Console.WriteLine(guy);

            foreach (var i in vec)
            {
                foreach (var j in vec)
                    if (j == i)
                        Console.WriteLine($"{j} and {i} are the same person");
            }

            Console.ReadKey();
        }
    }
}

