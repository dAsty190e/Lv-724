using System;
namespace Lesson4
{
    public class Person
    {      
            private string name;
            public string Name
            {
                set { name = value; }
                get { return name; }
            }
            private int birthYear;
            public int BirthYear
            {
                set { birthYear = value; }
                get { return birthYear; }
            }
            public int age;
            public Person()
            {
                name = "Vlad";
                birthYear = 2007;
            }
            public Person(string name, int birthYear)
            {
                this.name = name;
                this.birthYear = birthYear;
            }

            public static Person Input(int i)
            {
                Console.WriteLine($"Enter {i + 1} your name");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter {i + 1} your year of birth");
                string birthYear1 = Console.ReadLine();
                int birthYear = Convert.ToInt32(birthYear1);
                Person person = new Person(name, birthYear);
                return person;
            }
            public void Age()
            {
                var today = DateTime.Today;
                age = today.Year - birthYear;
            }
            public void ChangeName()
            {
                if (age < 16)
                {
                    name = "Very Young";
                }
            }
            public void Output()
            {
                Console.WriteLine($"the name is {name} the birth of year is {birthYear}, the age is {age}");
                Console.WriteLine("________________");
            }

            public static bool operator == (Person first, Person second)
            {
                return (first.name == second.name);
            }
            public static bool operator !=(Person first, Person second)
            {
                return !(first == second);
            }
            public override string ToString()
            {
                return $"the name is {name} the birth of year is {birthYear}, the age is {age}";
            }
        }
}
