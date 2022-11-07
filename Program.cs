using System;

namespace Homework2.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter 3 numbers");
            string first = Console.ReadLine();
            float number1 = float.Parse(first);
            string second = Console.ReadLine();
            float number2 = float.Parse(second);
            string third = Console.ReadLine();
            float number3 = float.Parse(third);
            if (number1 >= -5 && number1 <= 5)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            if (number2 >= -5 && number1 <= 5)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            if (number3 >= -5 && number1 <= 5)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            Console.ReadKey();

            //task 2
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter 3 numbers");
            string four = Console.ReadLine();
            int number4 = Convert.ToInt32(four);
            string five = Console.ReadLine();
            int number5 = Convert.ToInt32(five);
            string six = Console.ReadLine();
            int number6 = Convert.ToInt32(six);
            if (number4 > number5 && number4 > number5)
                Console.WriteLine("number one is the biggest");
            else if (number5 > number4 && number5 > number6)
                Console.WriteLine("number two is the biggest ");
            else
                Console.WriteLine("number three is the biggest");

            //task 4
            Console.WriteLine("Task 4");
            MyDog mydog;
            mydog.name = "Rex";
            mydog.mark = "dachshund";
            mydog.age = 2;

            mydog.info();

        }
    }
    struct MyDog
    {
        public string name;
        public string mark;
        public int age;

        public void info()
        {
            Console.WriteLine($"my dog name is {name}, mark is {mark} it is {age} years old");
        }
    }
}
