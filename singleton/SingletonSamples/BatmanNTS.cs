using System;

namespace SingletonSamples
{
    public sealed class BatmanNTS
    {
        // static instance
        private static BatmanNTS instance = null;

        // random value to identify the instance of Batman
        private readonly string batmanUID;

        // private parameterless constructor
        private BatmanNTS() 
        {
            // random value to identify the instance of Batman
            Random rand = new();
            batmanUID = $"BW{rand.Next(1000)}";
            Console.WriteLine($"... new instance of Batman created: {batmanUID}");
        }

        // public method to return the single instance - no thread-safe
        public static BatmanNTS Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new BatmanNTS();
                }
                return instance;
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
            return $"Don't panic! Batman {BatmanUID} is here, with his Batmobile!";
        }

    }
}
