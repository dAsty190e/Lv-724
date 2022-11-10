using System;

namespace Test2
{
    class Program
    {
        public struct Dog
        {
            public string name;
            public string mark;
            public int age;
        }
        enum errors
        {
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405
        }
        static void NumOfError(int x)
        {
            switch (x)
            {
                case 401:
                    Console.WriteLine("Unauthorized");
                    break;
                case 402:
                    Console.WriteLine("Payment_Required");
                    break;
                case 403:
                    Console.WriteLine("Forbidden");
                    break;
                case 404:
                    Console.WriteLine(" Not_Found ");
                    break;
                case 405:
                    Console.WriteLine("Method_Not_Allowed");
                    break;
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task1: ");
            Console.WriteLine("Enter 3 real digits: ");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            float c = Convert.ToSingle(Console.ReadLine());

            string result = (a >= -5 && a <= 5) && (b >= -5 && b <= 5) && (c >= -5 && c <= 5) ?
                "All digits in range" :
                "At least one of digits not in range";
            Console.WriteLine(result);
            Console.ReadKey();

            Console.WriteLine("Task2: ");
            Console.WriteLine("Enter 3 real digits: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            int max = (Math.Max(Math.Max(x1, x2), x3));
            int min = (Math.Min(Math.Min(x1, x2), x3));
            Console.WriteLine("Max Digit" + " " + max);
            Console.WriteLine("Min Digit" + " " + min);
            Console.ReadKey();

            Console.WriteLine("Task3: ");
            Console.WriteLine("Enter number of error: ");
            int num = Convert.ToInt32(Console.ReadLine());
            NumOfError(num);
            Console.ReadKey();

            Console.WriteLine("Task 4");
            Dog MyDog;
            Console.WriteLine("Enter  dog name: ");
            MyDog.name = Console.ReadLine();
            Console.WriteLine("Enter  dog mark: ");
            MyDog.mark = Console.ReadLine();
            Console.WriteLine("Enter  dog age: ");
            MyDog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The dog name is {0}, {1} mark and {2} years old", MyDog.name, MyDog.mark, MyDog.age);
            Console.ReadKey();

        }
        
    
    }
}
