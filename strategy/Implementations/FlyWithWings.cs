using System;

namespace strategy
{
    public class FlyWithWings : IFlyBehavior
    {    void IFlyBehavior.fly()
        {
            Console.WriteLine("I'm flying!! ");
        }
    }

}