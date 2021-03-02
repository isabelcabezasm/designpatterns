using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
  public interface ICostume
  {
    public string Suit { get; }
    public string Boots { get; }
    public string Mask { get; }
    public List<string> Accessories { get; }

    public string AssembleCostume();

  }
}
