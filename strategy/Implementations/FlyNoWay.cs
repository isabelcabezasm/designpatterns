
using System;

namespace strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly :( ");
        }
    }
}