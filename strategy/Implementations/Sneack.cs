using System;

namespace strategy
{
    public class Squeak : IQuackBehavior
{    public void quack()
    {
        Console.WriteLine("Squeak: Aaaaaahhh  !!");
    }
}
}
