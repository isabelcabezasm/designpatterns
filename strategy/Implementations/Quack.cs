using System;

namespace strategy
{
    public class Quack : IQuackable
{   public void quack()
    {
        Console.WriteLine("Quack!!");
    }
}
}
