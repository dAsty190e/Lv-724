using System;
namespace HW2_Cherniak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task 1 
			Console.WriteLine("Please, input first number in the range from -5 to 5");
			var firstNumber = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Please, input second number in the range from -5 to 5");
			var secondNumber = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Please, input third number in the range from -5 to 5");
			var thirdNumber = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine((firstNumber <= 5) && (firstNumber >= -5) ? "Your firstNumber in the range from -5 to 5" : "Error");
			Console.ReadKey();
			Console.WriteLine((secondNumber <= 5) && (secondNumber >= -5) ?
				"Your secondNumber in the range from -5 to 5" : "Error");
			Console.ReadKey();
			Console.WriteLine((thirdNumber <= 5) && (thirdNumber >= -5) ? "Your thirdNumber in the range from -5 to 5" : "Error");
			Console.ReadKey();
			//Task 2
			Console.WriteLine("Please, input three numbers");
			var first = Convert.ToInt32(Console.ReadLine());
			var second = Convert.ToInt32(Console.ReadLine());
			var third = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine((first > second) && (first > third) ? "Max value is first" : 
							  (second > first) && (second > third) ? "Max value is second" : "Max value is third");
			Console.WriteLine((first < second) && (first < third) ? "Min value is first" :
							  (second < first) && (second < third) ? "Min value is second" : "Min value is third");
			Console.ReadKey();
			Console.WriteLine("Please, input number of error");
			var result = Convert.ToInt32(Console.ReadLine());
			NumberOfError(result, HttpError.NotFound);
		}
		//Task 3

		enum HttpError
		{
			BadRequest = 400,
			Unauthorized = 401,
			Forbidden = 403,
			NotFound = 404
		}
		static void NumberOfError(int result, HttpError error)
		{
			switch (result)
			{
				case 400:
					{
						Console.WriteLine(HttpError.BadRequest);
						break;
					}
				case 401:
					{
						Console.WriteLine(HttpError.Unauthorized);
						break;
					}
				case 403:
					{
						Console.WriteLine(HttpError.Forbidden);
						break;
					}
				case 404:
					{
						Console.WriteLine(HttpError.NotFound);
						break;
					}
			}
		}
	}
}
