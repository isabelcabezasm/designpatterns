using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FactoryMethodSample
{
  public class GamoraCostume : ICostume
  {
    public string Suit { get => "Read leather suit"; }
    public string Boots { get => "Red boots"; }
    public string Mask { get => "No mask, black and pink hair"; }
    public List<string> Accessories { get => new List<string>() { "Sward" }; }

    public string AssembleCostume()
    {
      string result = $"> Gamora's costume:\n{Suit},\n{Boots},\n{Mask}.\nThis is the list of accessories: ";
      foreach (var item in Accessories)
        result += $"{item} ";

      return result;
    }
  }
}
