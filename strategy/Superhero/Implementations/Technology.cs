
using System;

namespace SuperheroStrategy
{
    public class Technology : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("I use a very advance technology for flying: jet boots, aircrafts, or a very cool cape made of fabric from the future.");
        }
    }
}