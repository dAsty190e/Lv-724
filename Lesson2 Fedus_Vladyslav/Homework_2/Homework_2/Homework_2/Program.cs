using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //  HOMEWORK    TASK_1

            Console.WriteLine("Type firstNum: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Type secondNum: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Type thirdNum: ");
            double thirdNum = double.Parse(Console.ReadLine());


            if ((firstNum >= -5 && firstNum <= 5)
               && (secondNum >= -5 && secondNum <= 5)
               && (thirdNum >= -5 && thirdNum <= 5))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            // HOMEWORK     TASK_2

            int  num_1= 1;
            int  num_2= 2;
            int  num_3= 3;

            if (num_1 < num_2 && num_1 < num_3)
            {
                Console.WriteLine(num_1 + " is min");
            }
            else if (num_2 < num_1 && num_2 < num_3)
            {
                Console.WriteLine(num_2 + " is min");
            }
            else
            {
                Console.WriteLine(num_3 + " is min");
            }

            if (num_1 > num_2 && num_1 > num_3)
            {
                Console.WriteLine(num_1 + " is max");
            }
            else if (num_2 > num_1 && num_2 > num_3)
            {
                Console.WriteLine(num_2 + " is max");
            }
            else
            {
                Console.WriteLine(num_3 + " is max");
            }






        }
    }
}
