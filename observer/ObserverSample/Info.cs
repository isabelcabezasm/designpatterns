using System;

namespace ObserverSample
{
  public class Info
  {
    public String CurrentLocation { get; set; }
    public String HungerLevel { get; set; }

    public Info(String currentLocation, String hungerLevel)
    {
      CurrentLocation = currentLocation;
      HungerLevel = hungerLevel;
    }
  }
}
