using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
  public abstract class CostumeShop
  {
    private ICostume costume;

    public abstract ICostume CreateCostume(string superheroe);

    public string ExhibitCostume(string superheroe)
    {
      costume = CreateCostume(superheroe);
      string assembled = costume.AssembleCostume();

      return $"-> Exhibit {superheroe} costume in the shop window: {assembled}";
    }
  }
}
