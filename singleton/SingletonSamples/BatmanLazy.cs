using System;

namespace SingletonSamples
{
    public sealed class BatmanLazy
    {
        // static lazy instance. 
        private static readonly Lazy<BatmanLazy> instance = new(() => new BatmanLazy() );

        private readonly string batmanUID;

        // private parameterless constructor
        private BatmanLazy() 
        {
            // random value to identify the instance of Batman
            Random rand = new();
            batmanUID = $"BW{rand.Next(1000)}";
            Console.WriteLine($"... new instance of Batman created: {batmanUID}");
        }

        // public method to return the single instance - thread safe
        public static BatmanLazy Instance
        {
            get
            {
                // lazy initialization is thread-safe
                return instance.Value;
            }
        }

        public string BatmanUID 
        { 
            get
            {
                return batmanUID;
            }
        }

        public string Message()
        {
            return $"Don't panic! Batman {batmanUID} is here, with his Batmobile!";
        }

    }
}
