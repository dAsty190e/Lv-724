using System;
using System.Collections.Generic;
using System.IO;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
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

