using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted List:");
            List<IDeveloper> developersList = new List<IDeveloper>();
            developersList.Add(new Programmer("Mykola", "C#"));
            developersList.Add(new Programmer("Oleg", "Java"));
            developersList.Add(new Builder("Ivan", "hammer"));
            developersList.Add(new Programmer("Kate", "Java"));
            developersList.Add(new Builder("Petro", "hammer"));
            developersList.Add(new Builder("Alex", "shovel"));

            foreach (IDeveloper developer in developersList)
            {
                developer.Create();
                developer.Destroy();
            }

            Console.WriteLine("________________________________");
            Console.WriteLine("Sorted List:");

            developersList.Sort();
            foreach (IDeveloper developer in developersList)
            {
                developer.Create();
                developer.Destroy();
            }
            Console.WriteLine("________________________________");

            Dictionary<uint, string> names = new Dictionary<uint, string>();
            Console.WriteLine("Please, enter 7 names and relevant IDs");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("ID: ");
                uint ID = uint.Parse(Console.ReadLine());
                names.Add(ID, name);
            }
            Console.Write("Enter ID to find the name:");
            uint id = uint.Parse(Console.ReadLine());
            bool found = true;
            foreach (KeyValuePair<uint, string> keyValue in names)
            {
                if (keyValue.Key == id)
                {
                    Console.WriteLine($"ID = {keyValue.Key} - Name is: {keyValue.Value}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("ID is not found");
            }
        }
    }




}