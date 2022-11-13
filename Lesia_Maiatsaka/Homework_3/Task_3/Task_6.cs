namespace Task_3
{
    public static class Task_6
    {
        public static int Run(string[] numbersAsStrings)
        {
            if (!IsValid(numbersAsStrings)) throw new Exception("Not enough #'s");
            var numbers = ParseNumbers(numbersAsStrings);
            return AnyNegative(numbers) ? GetProduct(numbers) : GetSum(numbers);
        }

        public static bool IsValid(IEnumerable<string> numbersAsStrings) => 
            numbersAsStrings.Count() >= 5;

        public static IEnumerable<int> ParseNumbers(IEnumerable<string> numbersAsStrings) => 
            numbersAsStrings.Select(e => int.Parse(e));

        public static bool AnyNegative(IEnumerable<int> numbers) => 
            numbers.Any(e => e < 0);

        public static int GetProduct(IEnumerable<int> numbers) => 
            numbers.Reverse().Take(5).Aggregate((first, second) => first * second);

        public static int GetSum(IEnumerable<int> numbers) => 
            numbers.Take(5).Sum();
    }
}
