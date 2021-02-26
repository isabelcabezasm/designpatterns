using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
    public class NotHumanHeroesCostumeShop : CostumeShop
    {
        public override ICostume CreateCostume(string superheroe)
        {
            return superheroe switch
            {
                "Thor" => new ThorCostume(),
                "Gamora" => new GamoraCostume(),
                _ => new UnavailableCostume(),
            };
        }
    }
}
