using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactorySample
{
    public class CostumeFactory
    {
        public ICostume CreateCostume(string superheroe)
        {
            return superheroe switch
            {
                "CaptainAmerica" => new CaptainAmericaCostume(),
                "Ironman" => new IronmanCostume(),
                "Thor" => new ThorCostume(),
                // to add a new superheroe costume, like Black Widow, you just add a case in the factory switch
                "BlackWidow" => new BlackWidowCostume(),
                _ => null,
            };
        }
    }
}
