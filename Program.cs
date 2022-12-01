
﻿using System;
using System.Collections.Generic;

namespace Homework8
{
    class Program
    {
        static void Main()
        {

            string userInput;
            List<Shape> shapes = new List<Shape>();
        a:
            try
            {
                do
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine("To add circle, type in \"circle\"");
                    Console.WriteLine("To add squere, type in \"squere\"");
                    Console.WriteLine("Type in sort to sort the list");
                    Console.WriteLine("Type in quit to end program");
                    Console.WriteLine("Type display, to display all shapes");
                    Console.WriteLine("==================================\n");
                    userInput = Console.ReadLine().ToLower();

                    switch (userInput)
                    {
                        case "circle":
                            Circle(ref shapes);
                            break;

                        case "squere":
                            Square(ref shapes);
                            break;

                        case "sort":
                            shapes.Sort();
                            break;

                        case "display":
                            Display(ref shapes);
                            break;

                        case "quit":
                            Console.WriteLine("Bye!");
                            break;

                        default:
                            Console.WriteLine("No such figure");
                            break;
                    }
                }
                while (userInput != "quit");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto a;

            }
            
            
        }

        // Helper functions
        static void Circle(ref List<Shape> shapes)
        {
            Console.WriteLine("Enter name and radius seperated by space: ");
            string[] temp = Console.ReadLine().Split(' ');
            string name = temp[0];
            decimal radius = Convert.ToDecimal(temp[1]);
            shapes.Add(new Circle(name, radius));
        }

        static void Square(ref List<Shape> shapes)
        {
            Console.WriteLine("Enter name and side length seperated by space: ");
            string[] temp = Console.ReadLine().Split(' ');
            string name = temp[0];
            decimal side = Convert.ToDecimal(temp[1]);
            shapes.Add(new Square(name, side));
        }

        static void Display(ref List<Shape> shapes)
        {
            if (shapes.Count > 0)
            {
                foreach (var shape in shapes)
                    Console.WriteLine(shape);
            }
            else
                Console.WriteLine("List is empty");
        }
    }
}


            string devPath = @"/Users/aleksandr/Desktop/SoftServe/28.12.22/Polymorphism/Devs.txt";
            List<Person> people = new List<Person>();

            StreamReader sr = new StreamReader(devPath);
            while (!sr.EndOfStream)
            {
                string tempName;
                int tempSalary;
                string tempLevel;

                tempName = sr.ReadLine();
                tempSalary = Convert.ToInt32(sr.ReadLine());
                tempLevel = sr.ReadLine();

                people.Add(new Developer(tempName, tempSalary, tempLevel));
            }

            sr.Close();

            people.Add(new Teacher("Zavushchak Iryna", 5000, "C# and OOP"));
            people.Add(new Teacher("Alibaba", 300, "Biology"));
            people.Add(new Teacher("Enstein Albert", 10000, "Physics"));

            people.Sort();
            DisplayPersons();


            List<Staff> employees = new List<Staff>();

            foreach (Staff employee in people)
            {
                employees.Add(employee);
            }

            DisplayStaff();
            employees.Sort();
            DisplayStaff();

            Console.WriteLine("Enter persons name to find (don't forget to prefix name with a \"Teacher\" if a person is a teacher): ");
            string searchedName = Console.ReadLine();

            bool flag = false;
            foreach(var person in employees)
            {
                if (person.Name == searchedName)
                {
                    Console.WriteLine("Ther person you've looked for: ");
                    person.Display();
                    flag = true;
                    break;
                }
            }

            if (!flag)
                Console.WriteLine("Person not found");

            string staffPath = @"/Users/aleksandr/Desktop/SoftServe/28.12.22/Polymorphism/Staff.txt";
            StreamWriter sw = new StreamWriter(staffPath);

            foreach (var worker in employees)
            {
                Developer p = worker as Developer;
                Teacher t = worker as Teacher;
                if (p != null)
                {
                    sw.WriteLine(p.Name);
                    sw.WriteLine("Salary: {0:C}", p.Salary);
                    sw.WriteLine($"Level: {p.Level}");
                    sw.WriteLine("--------------");
                }
                if (t!= null)
                {
                    sw.WriteLine(t.Name);
                    sw.WriteLine("Salary: {0:C}", t.Salary);
                    sw.WriteLine($"Subject: {t.Subject}");
                    sw.WriteLine("--------------");
                }
            }
            sw.Close();



            Console.ReadKey();


            // Functions
            void DisplayPersons()
            {
                foreach (var man in people)
                {
                    man.Display();
                    Console.WriteLine();
                }
                Console.WriteLine("===================");
            }

            void DisplayStaff()
            {
                foreach (var man in employees)
                {
                    man.Display();
                    Console.WriteLine();
                }
                Console.WriteLine("===================");
            }
        }
        
    }
}



