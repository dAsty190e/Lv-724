using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("How old are you, ");
            Console.Write(name);
            Console.Write("? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your name: ");
            Console.WriteLine(name);
            Console.Write("Your age: ");
            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}

