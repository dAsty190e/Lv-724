using System;

namespace SeletskiyHW2
{
    class Program
    {

        public enum HTTPErrors
        {
            BadRequest = 400,
            Unauthorized = 401,
            Forbidden = 403,
            NotFound = 404
        }

        public struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return string.Format("Dog's name is {0}, mark is {1}, age is {2}", name, mark, age);
            }
        }

        static void Main(string[] args)
        {
            void taskOne()
            {
                Console.WriteLine("Enter 3 float variables one by one below:");
                float[] enteredFloats = new float[3];

                for (int i = 0; i < 3; i++)
                {
                    enteredFloats[i] = float.Parse(Console.ReadLine());
                }

                for (int i = 0; i < enteredFloats.Length; i++)
                {
                    if (enteredFloats[i] > -5 && enteredFloats[i] < 5)
                    {
                        Console.WriteLine("{0} is OK", enteredFloats[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0} doesn't fit in", enteredFloats[i]);
                    }
                }
            }

            void taskTwo()
            {
                Console.WriteLine("Enter 3 integer variables one by one below:");
                int[] enteredIntegers = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    enteredIntegers[i] = int.Parse(Console.ReadLine());
                }

                int temp = 0;

                for (int i = 0; i <= enteredIntegers.Length - 1; i++)
                {
                    for (int j = i + 1; j < enteredIntegers.Length; j++)
                    {
                        if (enteredIntegers[i] < enteredIntegers[j])
                        {
                            temp = enteredIntegers[i];
                            enteredIntegers[i] = enteredIntegers[j];
                            enteredIntegers[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Max number is {0}, min is {1}", enteredIntegers[0], enteredIntegers[2]);
            }

            void taskThree()
            {
                Console.WriteLine("Enter the number your browser gave you:");
                int errorCode = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(HTTPErrors), errorCode))
                {
                    Console.WriteLine("This means {0}", Enum.GetName(typeof(HTTPErrors), errorCode));
                }
                else
                {
                    Console.WriteLine("404 error not found");
                }
            }

            taskOne();
            taskTwo();
            taskThree();

            Dog myDog;
            Console.WriteLine("Enter your dog's name:");
            myDog.name = Console.ReadLine();
            Console.WriteLine("Enter your dog's mark:");
            myDog.mark = Console.ReadLine();
            Console.WriteLine("Enter your dog's age:");
            myDog.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(myDog);
        }
    }
}
