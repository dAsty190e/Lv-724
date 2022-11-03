using System;

namespace HW1_Stanislav_Cherniak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task 1
			Console.WriteLine("Please, input the side of the square: ");
			var a = Convert.ToInt32(Console.ReadLine());
			var perimeter = a + a + a + a;
			var area = a * a;
			Console.WriteLine("Perimeter = " + perimeter);	
			Console.WriteLine("Area = " + area);
			Console.ReadKey();
			//Task 2
			Console.WriteLine("What is your name?");
			string name = Console.ReadLine();
			Console.WriteLine($"How old are you {name}?");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(name + " your age is " + age + " years");
			Console.ReadKey();
			//Task 3
			Console.WriteLine("Please, input number ");
			double r = Convert.ToDouble(Console.ReadLine());
			var length = 2 * Math.PI * r;
			var square = Math.PI * r * r;
			var volume = 4 / 3 * Math.PI * r * r * r;
			Console.WriteLine("Length of circle is " + length);
			Console.WriteLine("Square of circle is " + square);
			Console.WriteLine("Volume of circle is " + volume);
			Console.ReadKey();
		}
	}
}
