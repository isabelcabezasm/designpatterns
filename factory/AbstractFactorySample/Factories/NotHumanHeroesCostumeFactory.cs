using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    // This factory creates costumes using materials not available on Planet Earth
    public class NotHumanHeroesCostumeFactory : ICostumeFactory
    {
        public IManCostume CreateManCostume()
        {
            return new ThorCostume();
        }

        public IWomanCostume CreateWomanCostume()
        {
            return new GamoraCostume();
        }

        public string Description()
        {
            return "Materials retrieved somewhere in Space";
        }
    }
}
