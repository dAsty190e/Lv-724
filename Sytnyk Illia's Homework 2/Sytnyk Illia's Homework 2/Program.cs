using System;

namespace Sytnyk_Illia_s_Homework_2
{
    internal class Program
    {
        //Task3
        enum Erorrs
        {
            First = 401,
            Second,
            Third,
            Fourth,
            Fifth
        };

        static void HTTPError(Erorrs er)
        {
            switch (er)
            {
                case Erorrs.First:
                    Console.WriteLine("Unauthorized");
                    break;
                case Erorrs.Second:
                    Console.WriteLine("Payment Required");
                    break;
                case Erorrs.Third:
                    Console.WriteLine("Forbidden");
                    break;
                case Erorrs.Fourth:
                    Console.WriteLine("Not Found");
                    break;
                case Erorrs.Fifth:
                    Console.WriteLine("Method Not Allowed");
                    break;
            }
        }

        static void NumberError(int x)
        {
            switch (x)
            {
                case 401:
                    HTTPError(Erorrs.First);
                    break;
                case 402:
                    HTTPError(Erorrs.Second);
                    break;
                case 403:
                    HTTPError(Erorrs.Third);
                    break;
                case 404:
                    HTTPError(Erorrs.Fourth);
                    break;
                case 405:
                    HTTPError(Erorrs.Fifth);
                    break;
            }
        }


        //Task 4
        public struct Dog
        {
            public string name;
            public string mark;
            public int age;
        }


        //Extra task 5
        enum Food
        {
            Fish,
            Milk,
            Meat,
            BadFish
        }
        class Cat
        {
            public int satiety;

            public void EatSomething(Food f, Cat MCat)
            {
                switch (f)
                {
                    case Food.Milk:
                        MCat.satiety += 1;
                        break;
                    case Food.Fish:
                        MCat.satiety += 2;
                        break;
                    case Food.Meat:
                        MCat.satiety += 3;
                        break;
                    case Food.BadFish:
                        MCat.satiety -= 4;
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Task 1: ");
            Console.Write("Enter x1: ");
            float x1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter x2: ");
            float x2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter x3: ");
            float x3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(x1 >= 5 || x1 <= -5 ? "Not all numbers between -5 and 5" :
                x2 >= 5 || x2 <= -5 ? "Not all numbers between -5 and 5" :
                x3 >= 5 || x3 <= -5 ? "Not all numbers between -5 and 5" :
                "All numbers between -5 and 5");

            Console.ReadKey();


            //Task 2
            Console.WriteLine("\nTask 2: ");
            const int SIZE = 3;
            Console.Write("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[SIZE] { num1, num2, num3 };

            int min = num1;
            int max = num1;

            for (int i = 0; i < SIZE; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }

            for (int i = 0; i < SIZE; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }

            Console.WriteLine("\nMin number: " + min);
            Console.WriteLine("Max number : " + max);
            Console.ReadKey();


            //Task 3
            Console.WriteLine("\nTask 3: ");
            Console.WriteLine("Enter the number of error: ");
            int num = Convert.ToInt32(Console.ReadLine());
            NumberError(num);
            Console.ReadKey();


            //Task 4
            Console.WriteLine("\nTask 4: ");
            Dog MyDog;
            Console.WriteLine("Enter the dog name: ");
            MyDog.name = Console.ReadLine();
            Console.WriteLine("Enter the dog mark: ");
            MyDog.mark = Console.ReadLine();
            Console.WriteLine("Enter the dog age: ");
            MyDog.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The dog is {0}, {1} mark and {2} years old", MyDog.name, MyDog.mark, MyDog.age);
            Console.ReadKey();


            //Extra task 5
            Console.WriteLine("\nExtra task 5: ");
            Cat MyCat = new Cat();
            MyCat.satiety = 10;
            Console.WriteLine("Before: " + MyCat.satiety);
            MyCat.EatSomething(Food.Fish, MyCat);
            Console.WriteLine("After: " + MyCat.satiety);
            Console.ReadKey();
        }
    }
}
