using System.Collections.Generic;

namespace FactoryMethodSample
{
  public class IronmanCostume : ICostume
  {
    public string Suit { get => "Red armor showing arc reactor"; }
    public string Boots { get => "Red jet-boots"; }
    public string Mask { get => "Red and gold helmet"; }
    public List<string> Accessories { get => new List<string>() { "Jarvis", "Gloves with repulsor rays" }; }

    public string AssembleCostume()
    {
      string result = $"> Ironman's costume:\n{Suit}\n{Boots}\n{Mask}.\nThis is the list of accessories: ";
      foreach (var item in Accessories)
        result += $"{item} ";

      return result;
    }
  }
}
