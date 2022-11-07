using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Hunger
{
    internal class Cat
    {
        public int HungerLevel { get; set; } = 100;

        public string EatSomething(Food food) 
        {
            HungerLevel += (int)food;
            return $"My hunger level is {HungerLevel}";
        }
    }

    enum Food 
    {
        Fish = 15,
        Cat_Food = 30,
        Roach = 5,
        Water = 10
    }
}
