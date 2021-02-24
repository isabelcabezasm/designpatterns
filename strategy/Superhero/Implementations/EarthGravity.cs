using System;

namespace SuperheroStrategy
{
    public class EarthGravity : IFlyable
    {   
        public void fly()
        {
            Console.WriteLine("I'm from another planet where the gravity is much stronger than Earth's. So on Earth, with a weaker gravity and a kinder atmosphere, my organs can basically resist gravity so strongly. ");
        }
    }

}