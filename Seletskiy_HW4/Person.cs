using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Person
    {

        #region Fields

        private string name;
        private DateTime birthdayYear;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return name;
            }
        }

        public DateTime BirthdayYear
        {
            get
            {
                return birthdayYear;
            }
        }

        #endregion

        #region Constructors
        public Person() { }

        public Person(string name, DateTime birthdayYear)
        {
            this.name = name;
            this.birthdayYear = birthdayYear;
        }

        #endregion

        #region Methods

        public TimeSpan Age()
        {
            return (this.birthdayYear - DateTime.Now);
        }

        public void Input()
        {
            Console.WriteLine("Enter the name below");
            this.name = Console.ReadLine();

            Console.WriteLine("Enter the year of birth below (yyyy.mm.dd):");
            this.birthdayYear = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Input over.");
        }

        public void ChangeName(string newName)
        {
            this.name = newName;
        }

        public override string ToString()
        {
            return  "Name: " + this.name + "\nBirthday: " + this.birthdayYear;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        #region Overrides

        public static bool operator == (Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator != (Person first, Person second)
        {
            return first.name != second.name;
        }

        #endregion

        public void Menu()
        {
            Console.WriteLine("Enter the name of the method to call it \n(Age, Input, ChangeName, Output)\nOr type Exit to... well, exit.");
            string userMenuInput = Console.ReadLine().ToLower();

            while (userMenuInput != "exit")
            {
                switch (userMenuInput)
                {
                    case "age":
                        this.Age();
                        Console.WriteLine("Enter the next method or exit:");
                        userMenuInput = Console.ReadLine().ToLower();
                        break;

                    case "input":
                        this.Input();
                        Console.WriteLine("Enter the next method or exit:");
                        userMenuInput = Console.ReadLine().ToLower();
                        break;

                    case "changename":
                    case "change name":
                        Console.WriteLine("Please enter new name below:");
                        string newName = Console.ReadLine();
                        this.ChangeName(newName);
                        Console.WriteLine("Enter the next method or exit:");
                        userMenuInput = Console.ReadLine().ToLower();
                        break;

                    case "output":
                        this.Output();
                        Console.WriteLine("Enter the next method or exit:");
                        userMenuInput = Console.ReadLine().ToLower();
                        break;

                    default:
                        Console.WriteLine("Please enter a method.");
                        Console.WriteLine("Enter the next method or exit:");
                        userMenuInput = Console.ReadLine().ToLower();
                        break;
                }
            }
        }

        #endregion
    }
}
