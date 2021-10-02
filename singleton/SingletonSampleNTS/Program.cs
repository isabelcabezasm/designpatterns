using System;
using System.Threading;

namespace SingletonSampleNTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gordon needs Batman Help!");
            Thread.Sleep(2000);
            Batman batman = Batman.Instance;
            Thread.Sleep(2000);
            Console.WriteLine(batman.Message());

            Thread.Sleep(3000);

            Console.WriteLine("Now Alfred needs Batman Help!");
            Thread.Sleep(2000);
            batman = Batman.Instance;
            Thread.Sleep(2000);
            Console.WriteLine(batman.Message());

            Thread.Sleep(3000);

            Console.WriteLine("Oh no, Joker is robbing the bank!");
            Thread.Sleep(2000);
            batman = Batman.Instance;
            Thread.Sleep(2000);
            Console.WriteLine(batman.Message());

        }
    }
}
