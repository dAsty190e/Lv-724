using System;

namespace Task4_Car
{
    class Car
    {

        public readonly string make;
        string model;
        string colour;
        double price;

        public Car()
        {
            make = "VW";
            model = "Polo";
            colour = "white";
            price = 7000;

        }

        public Car(string make, string model, string colour, double price)
        {
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.price = price;
        }


        public string getColour()
        {
            return colour;
        }

        public void setColour(string colour)
        {
            this.colour = colour;
        }

        public void discount(double percent)
        {
            price -= price * (percent/100);
        }

        public static bool operator==( Car lhs, Car rhs)
        {
            return (lhs.model == rhs.model) && (lhs.price == rhs.price);
        }

        public static bool operator !=(Car lhs, Car rhs)
        {
            return !((lhs.model == rhs.model) && (lhs.price == rhs.price));
        }

        public override string ToString()
        {
            return $"Make: {make}\nModel: {model}\nColour: {colour}\nPrice: {price:c}";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Car[] cars = new Car[3];
            Input(cars);
            Output(cars);

            cars[0].discount(10);

            cars[1].setColour("Blue");
            Console.Write(cars[1]);

            Console.WriteLine(cars[1] == cars[2]);
            Console.ReadKey();
        }

        static void Input(Car[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string tempBrand;
                string tempModel;
                string tempColour;
                double tempPrice;

                Console.Write($"Enter the brand name of car {i + 1}: ");
                tempBrand = Console.ReadLine();

                Console.Write($"Enter the model of car {i + 1}: ");
                tempModel = Console.ReadLine();

                Console.Write($"Enter the colour of car {i + 1}: ");
                tempColour = Console.ReadLine();

                Console.Write($"Enter the price of car {i + 1}: ");
                tempPrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n");

                array[i] = new Car(tempBrand, tempModel, tempColour, tempPrice);
            }
        }

        static void Output(Car[] cars)
        {
            foreach (var car in cars)
                Console.WriteLine("{0}\n====================\n", car);
                
        }
    }
}

