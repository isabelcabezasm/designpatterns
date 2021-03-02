using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FactoryMethodSample
{
  public class ThorCostume : ICostume
  {
    public string Suit { get => "Leather suit"; }
    public string Boots { get => "Black boots"; }
    public string Mask { get => "Helmet with wings"; }
    public List<string> Accessories { get => new List<string>() { "Mjölnir", "Red cape" }; }

    public string AssembleCostume()
    {
      string result = $"> Thor's costume:\n{Suit},\n{Boots},\n{Mask}.\nThis is the list of accessories: ";
      foreach (var item in Accessories)
        result += $"{item} ";

      return result;
    }
  }
}
