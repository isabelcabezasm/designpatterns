
using System;

namespace strategy
{
}

public class FlyNoWay : IFlyBehavior
{
    void IFlyBehavior.fly()
    {
        Console.WriteLine("I can't fly :( ");
    }
}