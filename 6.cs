using System;

namespace HM6.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 numbers");
                Console.Write("number 1=");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("number 2=");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 == num2)
                {
                    throw new Exception("numbers must be different");
                }
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine("{0} / {1} = {2}", num1, num2, Div(num1, num2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("number 2 cannot be zero");
            }
            catch (FormatException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
