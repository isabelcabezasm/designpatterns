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
    public string ExhibitCostume(string superheroe)
    {
      costume = factory.CreateCostume(superheroe);
      string assembled = costume.AssembleCostume();

      return $"-> Exhibit {superheroe} costume in the shop window: {assembled}";
    }
  }
}
