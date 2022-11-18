using System;
using System.Collections.Generic;


namespace Task5
{
    class Program
    {
        static void Main()
        {
            List<IFlyable> flyingObj = new List<IFlyable>();
            flyingObj.Add(new Bird("Ostridge", false));
            flyingObj.Add(new Bird("Eagle", true));
            flyingObj.Add(new Plane("B-737", 15000));

            foreach (var obj in flyingObj)
            {
                obj.Fly();
            }

            List<int> myColl = new List<int>();
            fillList(myColl);
            searchList(myColl);
            displayList(myColl);
            removeFromList(myColl);
            displayList(myColl);

            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);

            displayList(myColl);

            myColl.Sort();

            displayList(myColl);

            Console.ReadKey();
        }

        static void fillList(List<int> list)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number {0}: ", i);
                int temp = Convert.ToInt32(Console.ReadLine());
                list.Add(temp);
            }
        }

        static void searchList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == -10)
                    Console.WriteLine("-10 at the locantion: {0}", i);
            }
        }

        static void removeFromList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 20)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
        }

        static void displayList(List<int> list)
        {
            Console.WriteLine("\n====");
            foreach (var el in list)
                Console.WriteLine(el);
            Console.WriteLine("\n====");
        }
        
    }
}

