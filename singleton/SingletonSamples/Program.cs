using System;
using System.Threading;

namespace SingletonSamples
{
    public class Program
    {
        static void Main()
        {
            SingleThreadApp();
            //MultiThreadApp("no thread-safe");
            //MultiThreadApp("lazy");
        }

        static void SingleThreadApp()
        {
            Console.WriteLine("Gordon needs Batman's help!");
            Thread.Sleep(1000);
            BatmanNTS batman = BatmanNTS.Instance;
            Thread.Sleep(1000);
            Console.WriteLine(batman.Message());

            Thread.Sleep(3000);

            Console.WriteLine("Now Alfred needs Batman at the Wayne Manor.");
            Thread.Sleep(1000);
            batman = BatmanNTS.Instance;
            Thread.Sleep(1000);
            Console.WriteLine(batman.Message());

            Thread.Sleep(3000);

            Console.WriteLine("Oh no, Joker is robbing the bank!");
            Thread.Sleep(1000);
            batman = BatmanNTS.Instance;
            Thread.Sleep(1000);
            Console.WriteLine(batman.Message());
        }

        static void MultiThreadApp(string implementation)
        {
            Thread Gordon;
            Thread Alfred;
            Thread Joker;

            switch (implementation)
            {
                case "no thread-safe":
                    // Creation of 3 different threads, using the no thread-safe implementation of Batman 
                    Gordon = new(RequestNTS);
                    Alfred = new(RequestNTS);
                    Joker = new(RequestNTS);
                    // Start the threads, passing the name as param
                    Gordon.Start("Gordon");
                    Alfred.Start("Alfred");
                    Joker.Start("Joker");
                    break;
                case "lazy":
                    // Creation of 3 different threads, using the no thread-safe implementation of Batman 
                    Gordon = new(RequestLazy);
                    Alfred = new(RequestLazy);
                    Joker = new(RequestLazy);
                    // Start the threads, passing the name as param
                    Gordon.Start("Gordon");
                    Alfred.Start("Alfred");
                    Joker.Start("Joker");
                    break;
            }

        }

        // delegate to be invoked for No Thread Safe requests
        public static void RequestNTS(object name)
        {
            string helpMessage = (string)name == "Joker" ? $"Oh no! {name} is robbing the bank!" : $"{name} needs Batman's help!";
            Console.WriteLine(helpMessage);
            Thread.Sleep(3000);
            BatmanNTS batman = BatmanNTS.Instance;
            Console.WriteLine($"{name}'s request: {batman.BatmanUID} is coming.");
            Console.WriteLine($"{name}'s Request: {batman.Message()}");
        }

        // delegate to be invoked for Lazy implementation - thread safe
        public static void RequestLazy(object name)
        {
            string helpMessage = (string)name == "Joker" ? $"Oh no! {name} is robbing the bank!" : $"{name} needs Batman's help!";
            Console.WriteLine(helpMessage);
            Thread.Sleep(3000);
            BatmanLazy batman = BatmanLazy.Instance;
            Console.WriteLine($"{name}'s request: {batman.BatmanUID} is coming.");
            Console.WriteLine($"{name}'s Request: {batman.Message()}");
        }


    }
}
