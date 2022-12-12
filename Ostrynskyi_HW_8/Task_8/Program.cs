using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persons> personsList = new List<Persons>();
            personsList.Add(new Teacher("Alex", "Math", 12000));
            personsList.Add(new Staff("Andriy", 12000));
            personsList.Add(new Staff("Sergiy", 10000));
            personsList.Add(new Teacher("Oleg", "English", 8000));
            personsList.Add(new Developer("Iryna", "Python", 21000));
            personsList.Add(new Developer("Kate", "C#", 15000));
            personsList.Add(new Developer("Mykola", "Ruby", 11000));

            foreach (var item in personsList)
            {
                item.Print();
            }

            Console.WriteLine("\nPlease, enter the name");
            string personName = Console.ReadLine();
            bool found = true;
            foreach (var item in personsList)
            {
                if (item.Name == personName)
                {
                    item.Print();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Name has not found");
            }

            personsList.Sort();
            string path = @"C:\Users\Dell\Desktop\names.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (var item in personsList)
                    sw.WriteLine(item.Name);
            }

            Console.WriteLine("\nSorted list of Employees by salary:");
            List<Staff> employees = new();
            foreach (Staff item in personsList)
            {
                if (item.GetType() == typeof(Developer))
                {
                    employees.Add(item);
                }
                if (item.GetType() == typeof(Teacher))
                {
                    employees.Add(item);
                }
            }
            foreach (var item in employees.OrderBy(salary => salary.Salary))
            {
                item.Print();
            }
        }
        
    }
}