
using System;

namespace SuperheroStrategy
{
    public class FlyNoWay : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("I can't fly :( ");
        }
    }
}