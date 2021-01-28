using System;

namespace strategy
{
    public class MuteQuack : IQuackBehavior
    {    public void quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}

