using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int S = a * a;
            int P = a * 4;
            Console.Write("Площадь квадрата равна: ");
            Console.WriteLine(S);
            Console.Write("Периметр квадирата равен: ");
            Console.WriteLine(P);
            Console.ReadKey();

        }
    }
}

