using System;
using System.Collections.Generic;

namespace ObserverSample
{
  class Program
  {
    static void Main(string[] args)
    {

      Gordon gordon = new Gordon();
      gordon.Hello();

      Console.WriteLine("------------------------------------------------");

      Alfred alfred = new Alfred();
      Robin robin = new Robin();
      Batgirl batgirl = new Batgirl();
      Catwoman catwoman = new Catwoman();

      // Alfred, Robin and Batgirl want to be notified
      alfred.Subscribe(gordon);
      robin.Subscribe(gordon);
      batgirl.Subscribe(gordon);

      Console.WriteLine("------------------------------------------------");

      // Gordon shares the information with all the observers
      gordon.GetInfo();

      Console.WriteLine("------------------------------------------------");

      batgirl.BuyPresents();
      System.Threading.Thread.Sleep(2000);
      robin.BuyFood();

      Console.WriteLine("------------------------------------------------");

      System.Threading.Thread.Sleep(5000);

      // Catwoman shows up and wants to participate to the party
      catwoman.Subscribe(gordon);
      // Robin needs to unsubscribe for a while
      robin.CatchTheBadGuy();

      Console.WriteLine("------------------------------------------------");
      // Gordon shares the information with all the observers
      gordon.GetInfo();

      Console.WriteLine("------------------------------------------------");

      batgirl.BuyBalloons();
      System.Threading.Thread.Sleep(2000);
      alfred.BuyCake();
      System.Threading.Thread.Sleep(2000);
      catwoman.BuyDrinks();

      Console.WriteLine("------------------------------------------------");

      System.Threading.Thread.Sleep(5000);
      // Robin is back
      robin.Subscribe(gordon);

      System.Threading.Thread.Sleep(2000);

      // Time to party!
      gordon.PartyTime();

    }
  }
}
