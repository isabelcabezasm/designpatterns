using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AbstractFactorySample
{
  public class BlackWidowCostume : IWomanCostume
  {
    public string Suit { get => "Black leather suit with boots"; }
    public string Hairstyle { get => "Red wig"; }
    public List<string> Accessories { get => new List<string>() { "Guns" }; }

    public string AssembleCostume()
    {
      string result = $"> BlackWidow's costume:\n{Suit},\n{Hairstyle}.\nThis is the list of accessories: ";
      foreach (var item in Accessories)
        result += $"{item} ";

      return result;
    }
  }
}
