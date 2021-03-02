using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactorySample
{
  public class CostumeFactory
  {
    public ICostume CreateCostume(string superheroe)
    {
      // to add a new superheroe costume, we just add a case in the factory switch
      return superheroe switch
      {
        "CaptainAmerica" => new CaptainAmericaCostume(),
        "Ironman" => new IronmanCostume(),
        "Thor" => new ThorCostume(),
        "BlackWidow" => new BlackWidowCostume(),
        // we want to notify if a costume is not available
        _ => new UnavailableCostume(),
      };
    }
  }
}
