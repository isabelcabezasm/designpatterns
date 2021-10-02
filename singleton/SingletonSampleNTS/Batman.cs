using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSampleNTS
{
    public sealed class Batman
    {
        // static instance
        private static Batman instance = null;

        // private parameterless constructor
        private Batman() { }

        // public method to return the single instance - no thread-safe
        public static Batman Instance
        {
            get
            {
                if(instance == null)
                {
                    Console.WriteLine("... Creating an new instance of Batman ...");
                    instance = new Batman();
                }
                // the else clause is not required for the pattern, it's just for demo purpose
                else
                {
                    Console.WriteLine("... Same old instance of Batman ...");
                }
                return instance;
            }
        }

        private static string Name 
        { 
            get
            {
                return "Bruce Wayne";
            }
        }

        public string Car
        {
            get
            {
                return "Batmobile";
            }
        }

        public string Message()
        {
            return $"Don't panic! Batman is here, with his {Car}!";
        }

    }
}
