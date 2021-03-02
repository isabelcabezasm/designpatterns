using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    // This factory creates costumes using materials available on Planet Earth
    public class HumanHeroesCostumeFactory : ICostumeFactory
    {
        public IManCostume CreateManCostume()
        {
            return new IronmanCostume();
        }

        public IWomanCostume CreateWomanCostume()
        {
            return new BlackWidowCostume();
        }

        public string Description()
        {
            return "Materials available on Planet Earth";
        }
    }
}
