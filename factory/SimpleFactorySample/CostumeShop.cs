using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactorySample
{
    public class CostumeShop
    {
        private ICostume costume;
        private readonly CostumeFactory factory;

        public CostumeShop(CostumeFactory factory)
        {
            this.factory = factory;
        }
        public string ViewCostume(string superheroe)
        {
            costume = factory.CreateCostume(superheroe);
            return costume.AssembleCostume();
        }
    }
}
