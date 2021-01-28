using System;

namespace strategy
{
    public class Quack : IQuackBehavior
{   public void quack()
    {
        Console.WriteLine("Quack!!");
    }
}
}
