using System;

namespace strategy
{
    public class MuteQuack : IQuackable
    {    public void quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}

