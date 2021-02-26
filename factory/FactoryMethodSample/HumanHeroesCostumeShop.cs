using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
    public class HumanHeroesCostumeShop : CostumeShop
    {
        public override ICostume CreateCostume(string superheroe)
        {
            return superheroe switch
            {
                "CaptainAmerica" => new CaptainAmericaCostume(),
                "Ironman" => new IronmanCostume(),
                "BlackWidow" => new BlackWidowCostume(),
                _ => new UnavailableCostume(),
            };
        }
    }
}
