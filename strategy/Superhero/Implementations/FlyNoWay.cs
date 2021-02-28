
using System;

namespace SuperheroStrategy
{
    public class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly :( ");
        }
    }
}