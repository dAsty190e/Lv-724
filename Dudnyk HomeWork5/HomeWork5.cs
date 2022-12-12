using System;
using System.Collections.Generic;

namespace HomeWork5
{
    class Program
    {
        static void Main()
        {

            List<IDeveloper> arr = new List<IDeveloper>();

            arr.Add(new Builder());
            arr.Add(new Programer());
            arr.Add(new Programer("C++"));
            arr.Add(new Builder("Screwdriver"));
            arr.Add(new Builder("Pliers"));
            arr.Add(new Builder("Wrench"));
            arr.Add(new Programer("Java"));
            arr.Add(new Programer("C"));
            arr.Add(new Programer("Assembly"));
            arr.Add(new Programer("Pascal"));

            foreach (var a in arr)
                a.Create();

            foreach (var a in arr)
                a.Destroy();

            arr.Sort();

            foreach (var a in arr)
                Console.Write(a);


            Console.WriteLine("------------------------------\n\n");


            //Part 2

            Dictionary<uint, string> presidents = new Dictionary<uint, string>();
            presidents.Add(1, "Washington");
            presidents.Add(2, "Adams");
            presidents.Add(3, "Jefferson");
            presidents.Add(4, "Madison");
            presidents.Add(5, "Monroe");
            presidents.Add(6, "Adams");
            presidents.Add(7, "Jackson");

            uint selection = 0;
            do
            {
                Console.Write("Enter the number of US president from 1 to 7 (or enter 55 to exit): ");
                selection = Convert.ToUInt32(Console.ReadLine());

                if (selection != 55)
                    Console.WriteLine(presidents.GetValueOrDefault(selection));
            }
            while (selection != 55);


            Console.ReadKey();
        }
    }
}

