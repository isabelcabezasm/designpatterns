using System;

namespace strategy
{
    public class FlyWithWings : IFlyBehavior
    {   
        public void fly()
        {
            Console.WriteLine("I'm flying!! ");
        }
    }

}