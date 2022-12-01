using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostapchuk_HW_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint key;
            string val;

            Dictionary<uint, string> personInfo = new Dictionary<uint, string>();
            personInfo.Add(1, "Person 1");
            personInfo.Add(2, "Person 2");
            personInfo.Add(3, "Person 3");
            personInfo.Add(4, "Person 4");
            personInfo.Add(5, "Person 5");
            personInfo.Add(6, "Person 6");
            personInfo.Add(7, "Person 7");

            for (int i = 0; i < personInfo.Count; i++)
            {
                Console.WriteLine("Key " + personInfo.ElementAt(i).Key + " Person " + personInfo.ElementAt(i).Value);
            }
            Console.Write("Enter user ID Key: ");
            uint userIdKey = Convert.ToUInt32(Console.ReadLine());
            if (personInfo.ContainsKey(userIdKey))
            {
                Console.WriteLine(personInfo[userIdKey]);
            }
            else
            {
                Console.WriteLine($"There is no user to associated with ID Key {userIdKey}");
            }

            Console.ReadKey();
        }
    }
}
