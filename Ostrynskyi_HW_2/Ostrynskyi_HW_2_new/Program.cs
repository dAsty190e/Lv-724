using System;

namespace Homework_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter three float numbers");

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float x = 5;
            float y = -5;

            string result = (x >= a && a >= y) && (x >= b && b >= y) && (x >= c && c >= y) ?
                "Your numbers are in the range [-5.5]" :
                "At least one of the float numbers is out of range range [-5.5]";

            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Please, enter three integer numbers");

            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());

            int max = (d > e && d > e) ? d : (e > f) ? e : f;
            int min = (d < e && d < e) ? d : (e < f) ? e : f;

            Console.WriteLine($"The Max number is {max} and the Min number is {min}");
            Console.WriteLine();
            //альтерантаивний варіант:

            //int max = (Math.Max(Math.Max(d, e), f));
            //int min = (Math.Min(Math.Min(d, e), f));

            //Console.WriteLine($"The Max number is {max} and the Min number is {min}");

            Console.WriteLine("Please, enter the number of HTTP error (400, 401,402, ...)");
            int value = Convert.ToInt32(Console.ReadLine()); ;
            string error = Enum.GetName(typeof(Errors), value);
            Console.WriteLine(error);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Task 4");
            Dog myDog;
            myDog.name = "Silver";
            myDog.mark = "corgy";
            myDog.age = "5";

            Console.WriteLine(myDog);
        }

        enum Errors
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405
        }

        struct Dog
        {
            public string name;
            public string mark;
            public string age;
            public override string ToString()
            {
                return string.Format("My dog {0} is {2} years old {1}", name, mark, age);
            }
        };
    }
}