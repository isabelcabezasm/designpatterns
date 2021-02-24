using System;

namespace strategy
{
    public class FlyWithWings : IFlyable
    {   
        public void fly()
        {
            Console.WriteLine("I'm flying!! ");
        }
    }

}