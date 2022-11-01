namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define integer variables a and b.
            Console.WriteLine("Lets us calculate numbers");
            Console.WriteLine("Put your number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Put your number b: ");
            int b = int.Parse(Console.ReadLine());
            

            Console.WriteLine($"Your addition number is: {a} + {b} = " + (a + b));
            Console.WriteLine($"Your subtraction number is: {a} - {b} = " + (a - b));
            Console.WriteLine($"Your multiplication number is: {a} * {b} = " + (a * b));
            Console.WriteLine($"Your divide number is: {a} / {b} = " + (a / b));


            // Output question “How are you?“

            Console.WriteLine("\nWhat is your name?");
            var userInput = Console.ReadLine();
            var name = userInput;

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"\nNice to meet you {name}");
                Console.WriteLine($"\nHow are you {name}? a/b");
                Console.WriteLine("\n a.Good");
                Console.WriteLine("\n b.Not so good");
                char answer = Console.ReadKey().KeyChar;
                _ = Console.ReadLine();


                if (char.ToLower(answer) == 'a')
                {
                    Console.WriteLine($"\nGlad to hear it!");
                }
                else if (char.ToLower(answer) == 'b')
                {
                    Console.WriteLine($"\nHope your day will be better!");
                }
            }

            // Read 3 variables of char type

            Console.WriteLine("\nDo you want choose a pet! y/n");
            var petChoice = Console.ReadKey().KeyChar;

            if (char.ToLower(petChoice) == 'y')
            {
                Console.WriteLine("\nWhat pet do you like? a/b/c");
                Console.WriteLine("\n a.Dog");
                Console.WriteLine("\n b.Cat");
                Console.WriteLine("\n c.Perrot");

                var petInput = Console.ReadLine();
                petInput = petInput.ToLower();

                if (petInput == "a")
                {
                    Console.WriteLine($"\nIt is your dog now {name}");
                }
                else if (petInput == "b")
                {
                    Console.WriteLine($"\nIt is your cat now {name}");
                }
                else if (petInput == "c")
                {
                    Console.WriteLine($"\nPerrot is yours now {name}");
                }

            }
            else if (char.ToLower(petChoice) == 'n')
            {
                Console.WriteLine("\nSee you next time!");
            }
            Console.WriteLine("");

            // Enter 2 integer numbers
            // Check if they are both positive – use bool expression

            Console.WriteLine("Numbers positive/negative check");
            Console.WriteLine("Put your number A: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Put your number B: ");
            int d = int.Parse(Console.ReadLine());

            if ((c == d))
            {
                Console.WriteLine("They equal to each other");
            }
            
            if ((c < 0) && (d > 0))
            {
                Console.WriteLine("A is negative and B is positive");
            }
            
            if ((c > 0) && (d < 0))
            {
                Console.WriteLine("A is positive and B is negative");
            }

            if ((c > 0) && (d > 0))
            {
                Console.WriteLine("They both positive");
            }

            if ((c < 0) && (d < 0))
            {
                Console.WriteLine("They both negative");
            }


            Console.WriteLine("\n");
        }
    }
}