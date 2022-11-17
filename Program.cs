using System;

namespace Sytnyk_Illia_s_Homework_4
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public Person() { }
        
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public int Age()
        {
            var today = DateTime.Today;
            int age = today.Year - birthYear.Year;
            return age;
        }

        public void Input()
        {
            Console.WriteLine("Enter the name of a person: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the birthday year of a person: ");
            birthYear = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("------------------------------");
        }

        public string ChangeName(string new_name)
        {
            name = new_name;
            return name;
        }

        public override string ToString()
        {
            return $"Person name is {name} and birthday year is {birthYear.Year}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator == (Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return first.name != second.name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p_1 = new Person("Illya", new DateTime (2003, 07, 24));
            Person p_2 = new Person("Volodymyr", new DateTime(1978, 01, 25));
            Person p_3 = new Person("Petro", new DateTime(1965, 09, 26));
            Person p_4 = new Person("Valeriy", new DateTime(1973, 07, 08));
            Person p_5 = new Person("Olena", new DateTime(1978, 02, 06));
            Person p_6 = new Person("Yulia", new DateTime(1960, 11, 27));

            Person[] people = { p_1, p_2, p_3, p_4, p_5, p_6 };
            Console.WriteLine("------------------------------");

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Person {i+1} is {people[i].Age()} years old");
            }

            for(int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }
            Console.WriteLine("------------------------------");

            for (int i = 0; i < people.Length; i++)
            {
                people[i].Output();
            }
            Console.WriteLine("------------------------------");

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i+1; j < people.Length; j++)
                {
                    if(people[i] == people[j])
                    {
                        Console.WriteLine($"Names of {i+1} person and {j+1} person are the same");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}