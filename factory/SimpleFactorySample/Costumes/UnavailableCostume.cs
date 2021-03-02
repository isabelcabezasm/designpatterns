using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SimpleFactorySample
{
  // This is used to notify if a costume is not available and avoid the system to crash
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
