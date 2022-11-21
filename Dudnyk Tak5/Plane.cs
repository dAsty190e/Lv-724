using System;
namespace Task5
{
    public class Plane : IFlyable
    {
        string make;
        int flightLevel;

        public Plane(string make, int flightLevel)
        {
            this.make = make;
            this.flightLevel = flightLevel;
        }

        public void Fly()
        {
            Console.WriteLine($"The maximum height a {make} can reach is {flightLevel}");
        }
    }
}

