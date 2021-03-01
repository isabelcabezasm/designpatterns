using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    public interface ICostumeFactory
    {
        public IWomanCostume CreateWomanCostume();
        public IManCostume CreateManCostume();
        public string Description();
    }
}
