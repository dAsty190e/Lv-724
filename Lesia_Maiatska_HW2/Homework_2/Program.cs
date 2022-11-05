namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1 (firs method)
            float a = -5.5f;
            float b = -2f;
            float c = 4f;

            if ((a >= -5 && a <= 5) 
                && (b >= -5 && b <= 5)
                && (c >= -5 && c <= 5))
            {
                Console.WriteLine(true);
            }
            else {
                Console.WriteLine(false);
            }

            // (second method)
            a = -3f;
            b = 0f;
            c = 4f;
            var ansver = (a >= -5 && a <= 5) ? 
                (b >= -5 && b <= 5) ? 
                (c >= -5 && c <= 5) ? 
                true : false : false: false;
            Console.WriteLine(ansver);

            // #2

            int myInt1 = 1;
            int myInt2 = 2;
            int myInt3 = 3;

            if (myInt1 < myInt2 && myInt1 < myInt3)
            {
                Console.WriteLine(myInt1 + " is min");
            }
            else if (myInt2 < myInt1 && myInt2 < myInt3)
            {
                Console.WriteLine(myInt2 + " is min");
            }
            else
            {
                Console.WriteLine(myInt3 + " is min");
            }

            if (myInt1 > myInt2 && myInt1 > myInt3)
            {
                Console.WriteLine(myInt1 + " is max");
            }
            else if (myInt2 > myInt1 && myInt2 > myInt3)
            {
                Console.WriteLine(myInt2 + " is max");
            }
            else
            {
                Console.WriteLine(myInt3 + " is max");
            }

            // #3

            Console.WriteLine("\nGive me an Error number");
            foreach (var error in Enum.GetValues(typeof(HTTP_ERROR)))
            {
                Console.WriteLine(Convert.ToInt32(error));
            }
            var userNumber = Console.ReadLine();
            var number = int.Parse(userNumber);
            var nameError = Enum.GetName(typeof(HTTP_ERROR), number);
            Console.WriteLine(nameError);

            // #4
            
            var myDog = new Dog();
            myDog.Name = "Jack";
            myDog.Mark = "Golden Retriever";
            myDog.Age = 5;
            //Console.WriteLine($"My dog name {myDog.Name}, he is {myDog.Mark}. He is {myDog.Age}");
            Console.WriteLine(myDog);
        }
    }

    enum HTTP_ERROR 
    {
        BadRequest = 400,
        Unauthorized = 401,
        ServerReject = 403,
        NotFound = 404,
        ServerError = 500
    }

    public struct Dog 
    {
        public string Name { get; set; }
        public string Mark { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"My dog name {Name}, he is {Mark}. He is {Age}";
        }
    }
}