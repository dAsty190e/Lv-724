using System;
using System.Collections.Generic;
using System.Linq;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>() { 9, -3, -5, 6,3,8, -5, -1, 8, -3};

            var s = from l in list
                    where l < 0
                    select l;


            //foreach (var item in s)
            //    Console.Write(item + " ");

            var p = from l in list
                    where l >= 0
                    select l;

            //foreach (var item in p)
                //Console.Write(item + " ");

            var max = list.Max();
            var min = list.Min();

            Console.WriteLine(min + " " + max);

            var firstMax = from item in list
                           where item > list.Average()
                           select list.FirstOrDefault();

            Console.WriteLine(list.Where(i => i > list.Average()).FirstOrDefault());

            var newList = list.OrderBy(i => i);

            foreach (var item in newList)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}

