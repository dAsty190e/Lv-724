using System;



namespace CalculatorSpace
{
    public class Calculator
    {
        public int Addition (int x, int y)
        {
            return x + y;
        }

        public int Subtraction (int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public float Division(int x, int y)
        {
            return (float)x / (float)y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
