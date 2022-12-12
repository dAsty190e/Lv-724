﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_4
{
    public class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int age = (DateTime.Today.Year) - (birthYear.Year);
            return age;
        }
        public static Person Input(int i)
        {
            Console.Write($"Please, enter name of the {i + 1} person: ");
            string name = Console.ReadLine();
            Console.Write($"Please, enter the birth year ('days'. 'month'. 'year'):");
            var birthYear = Convert.ToDateTime(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }
        public void ChangeName(int age)
        {
            if (age < 16)
            {
                name = "Very Young";
            }
        }
        public void Output()
        {
            Console.WriteLine($"{name} was born {birthYear}");
        }
        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
}
