using System;

namespace DudnykHW2
{
    enum Food { Mouse, Fish, Milk, Cheese}
    internal class Cat
    {
        private int satiaty = 0;
        public string toEat(Food obj)
        {
            switch(obj)
            {
                case Food.Mouse:
                    satiaty += 4;
                    return String.Format($"Love mice, my level of satiaty is {satiaty}");
              
                case Food.Fish:
                    satiaty += 3;
                    return String.Format($"Love fish, my level of satiaty is {satiaty}");
                    
                case Food.Milk:
                    satiaty++;
                    return String.Format($"Love milk, my level of satiaty is {satiaty}");
                    
                case Food.Cheese:
                    satiaty++;
                    return String.Format($"Cheese is also fine, my level of satiaty is {satiaty}");    
            }
            return String.Empty;
        }
    }
}
