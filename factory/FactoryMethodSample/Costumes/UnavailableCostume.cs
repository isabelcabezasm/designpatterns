using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FactoryMethodSample
{
  public class UnavailableCostume : ICostume
  {
    public string Suit { get => String.Empty; }
    public string Boots { get => String.Empty; }
    public string Mask { get => String.Empty; }
    public List<string> Accessories { get => new List<string>(); }

    public string AssembleCostume()
    {
      return "> Unavailable costume";
    }
  }
}
