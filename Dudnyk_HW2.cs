using System;
using DudnykHW2;

namespace Project1
{
    class Program
    {
        enum HTTPError { BadRequest = 400, Unothorized, PayementRequired, Forbidden, NotFound }

        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return "My dogs' name is " + name + " he lives in a village with my grandmother, he is around " + age + " years old, his mark is " + mark + "\n";
            }
        }

        static void Main()
        {
            //Task 1
            int n = 3;
            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter {i + 1} float number: ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            bool isInRange = true;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 5 || arr[i] < -5)
                {
                    Console.WriteLine($"{arr[i]} is not in range");
                    isInRange = false;
                }
            }

            if (isInRange)
                Console.WriteLine("All numbers are in range\n");



            //Task2
            int[] nums = new int[n];

            for (int i = 0; i < n; ++i)
            {
                Console.Write($"Enter {i + 1} integer number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int minVal = nums[0];
            int maxVal = nums[0];

            for (int i = 0; i < n; ++i)
            {
                if (minVal > nums[i])
                    minVal = nums[i];

                if (maxVal < nums[i])
                    maxVal = nums[i];
            }

            Console.WriteLine($"The smallest number is {minVal}, and the biggest number is {maxVal}\n");



            //Task3
            HTTPError err = HTTPError.NotFound;

            switch (err)
            {
                case HTTPError.BadRequest:
                    Console.WriteLine("Bad Reques");
                    break;

                case HTTPError.Unothorized:
                    Console.WriteLine("Unothorized");
                    break;

                case HTTPError.PayementRequired:
                    Console.WriteLine("Payment required");
                    break;

                case HTTPError.Forbidden:
                    Console.WriteLine("Forbidden");
                    break;

                case HTTPError.NotFound:
                    Console.WriteLine("Not Found");
                    break;

            }



            //Task4

            Dog mydog;
            mydog.age = 69;
            mydog.mark = "Dog";
            mydog.name = "Tuzik";
            Console.WriteLine(mydog);



            //Additional task

            Food cheese = Food.Cheese;
            Food fish = Food.Fish;
            Food milk = Food.Milk;  
            Food mouse = Food.Mouse;

            Cat Stray = new Cat(); 
            
            Console.WriteLine(Stray.toEat(fish));
            Console.WriteLine(Stray.toEat(milk));
            Console.WriteLine(Stray.toEat(mouse));
            Console.WriteLine(Stray.toEat(cheese));

            Console.ReadKey();
        }

    }
}

