using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostapchuk_HW_4
{
    internal class Person
    {
        //two private fields: name and birthYear (the birthday year).
        private string name;
        private int birthYear;
        private int age;
        

        //two properties for access to these fields (can use only get)
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        
        //default constructor and constructor with 2 parameters 
        //Parameterless constructor
        public Person() 
        {
            name = "Person 1";
            birthYear = 2021;

            //DateTime birthYear = new DateTime(2021, 11, 13);
        }


        //Constructor with Parameters
        public Person(string name, int birthYear)
        {
            this.name = name;
            this.BirthYear = birthYear;
        }
        //method - Input() - to enter data about person from console
        public static Person Input(int i)
        {
            Console.Write($"Enter Person {i + 1} name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter Person {i + 1} birth date : ");
            int birthYear = Convert.ToInt32(Console.ReadLine()); 
            Person myPerson = new Person(name, birthYear);
            return myPerson;

        }

        //int age; //?????

        //methods: - Age() - to calculate the age of person
        public int PersonAge()
        {
            int yearNow = DateTime.Now.Year;
            int age = yearNow - birthYear;
            this.Age = age;
            Console.WriteLine($"{name} was born in {birthYear}. Current year is {yearNow} The age is {age}");
            
            return age;                     ///????
            
        }
        

        //Output() - to output information about person (call ToString())
        public void Output()
        {
            Console.WriteLine(ToString());
        }

        //Override ToString()
        public override string ToString()
        {
            return "Person " + name + " born in " + birthYear +
                " is " + age + " years old";
            //return "Person " + name + " born in " + birthYear + " is " + age + " years old";
        }

        //ChangeName() - to change the name of person
        public void ChangeName(string newName)
        {
            this.name = newName;
           
        }

        //Overload operator == for the class Person (persons - equal if the name and age are equal)
        public static bool operator == (Person first, Person second)
        {
            return (first.Name == second.Name) && (first.Age == second.Age);
        }
        public static bool operator != (Person first, Person second)
        {
            return !(first == second);
        }


       
    }
}
