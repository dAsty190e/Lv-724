
﻿using System;

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
}
=======

﻿using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Output();

            Person person2 = new Person("fjkvfdv", 2002);
            person2.Output();
            Person[] persons = new Person[6];
            persons[0] = person;
            persons[1] = person2;
            for (int i = 2; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Age();
                persons[i].Output();
            }
            string newName = "Very Young";
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].age < 16)
                {
                    persons[i].Name = newName;
                    Console.WriteLine($"people number {i + 1} has new name - {newName}");
                }
            }
            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"people number {i + 1} and {j + 1}  have the same name");
                    }
                }
            }
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }
}


