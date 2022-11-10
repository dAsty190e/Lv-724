using System;

namespace _3HW_Cherniak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task 1
			Console.WriteLine("Input word");
			string word = Console.ReadLine().ToLower();
			int a = 0;
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] == 'a')
					a++;
				else if (word[i] == 'o')
					a++;
				else if (word[i] == 'i')
					a++;
				else if (word[i] == 'e')
					a++;
			}
			Console.WriteLine(a);
			Console.ReadKey();

			//Task 2 - Тут зроблено простішим способом, як на мене, але не повністю відповідає вимогам завдання.
			Console.WriteLine("Hello, user! Please, input the number of month");
			int month1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Now, please, input the number of year");
			int year1 = Convert.ToInt32(Console.ReadLine());
			int result = DateTime.DaysInMonth(year1, month1);
			Console.WriteLine("The count of days in this month are equal " + result);
			Console.ReadKey();

			//Task 2.1 - Тут я зробив конкретно так, як було поставлено вимогу.

			Console.WriteLine("Please, input the number of month");
			int month2 = Convert.ToInt32(Console.ReadLine());
			var year2 = 2022;
			if (month2 == 2)
			{
				Console.WriteLine("Please, input the number of year");
				year2 = Convert.ToInt32(Console.ReadLine());
			}
			Console.ReadKey();
			int results = DateTime.DaysInMonth(year2, month2);
			Console.WriteLine("The count of days in this month are equal " + results);

			//Task 3 
			int[] numbers = new int[10];
			Console.WriteLine("Please, input ten numbers");
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = Convert.ToInt32(Console.ReadLine());
			}
			int res = 0;
			for (int i = 0; i < 5; i++)
			{
				if (numbers[i] >= 0)
				{
					res = res + numbers[i];
				}
				else if (numbers[i] < 0)
				{
					res = numbers[5] * numbers[6] * numbers[7] * numbers[8] * numbers[9];
					Console.WriteLine("Product of the last five elements equal : " + res);
					break;
				}
			}
			Console.WriteLine("Sum of the first five elements equal : " + res);
		}
	}
}
