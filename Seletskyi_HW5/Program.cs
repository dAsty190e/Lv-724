using System;
using System.Collections.Generic;

namespace Seletskiy_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer cSharpDev = new Programmer("c#", "C# developer");
            Programmer javaDev = new Programmer("java", "Java developer");
            Builder carpenter = new Builder("hammer", "Carpenter");
            Builder plumber = new Builder("pipe wrench", "Plumber");

            List<IDeveloper> devs = new List<IDeveloper>();

            devs.Add(cSharpDev);
            devs.Add(javaDev);
            devs.Add(carpenter);
            devs.Add(plumber);

            foreach(IDeveloper dev in devs)
            {
                dev.Create();
                dev.Destroy();
            }

            devs.Sort();

            foreach (IDeveloper dev in devs)
            {
                Console.WriteLine(dev.Profession);
            }

            Dictionary<uint, string> sbuDatabase = new Dictionary<uint, string>();

            for (int i = 0; i < 7; i++)
            {
                uint tempID = 0;
                string tempName = "";
                Console.WriteLine("Enter a Person's ID:");
                tempID = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Enter a Person's name:");
                tempName = Console.ReadLine();
                sbuDatabase.Add(tempID, tempName);
            }

            Console.WriteLine("Enter the ID you want to look up:");
            uint idToLookUp = Convert.ToUInt32(Console.ReadLine());

            if (sbuDatabase.TryGetValue(idToLookUp, out string name))
            {
                Console.WriteLine("Your guy is {0}", name);
            }
            else
            {
                Console.WriteLine("We couldn't find your guy");
            }
        }
    }
}
