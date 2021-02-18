using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSample
{
  public class Alfred : IObserver<Info>
  {
    private string name = "Alfred";
    private IDisposable unsubscriber;
    private Info lastInfo;

    public virtual void Subscribe(IObservable<Info> provider)
    {
      // the unsubscriber variable can be used to unsubscribe at any time
      unsubscriber = provider.Subscribe(this);
      Console.WriteLine($"{name}: subscribed");
    }

    public virtual void Unsubscribe()
    {
      unsubscriber.Dispose();
    }

    public void OnCompleted()
    {
      Console.WriteLine($"{name}: Ready for the surprise party!");
    }

    public void OnError(Exception error)
    {
      // this is not used in this sample
      throw new NotImplementedException();
    }

    public void OnNext(Info value)
    {

      Console.WriteLine($"{name}: latest info from Gordon -> location: {value.CurrentLocation}, Batman is {value.HungerLevel}");
      lastInfo = value;
    }

    public void BuyCake()
    {
      if (lastInfo.HungerLevel == "starving")
        Console.WriteLine($"{name}: I bought a HUGE cake!");
      else
        Console.WriteLine($"{name}: I bought a small cake, but it's so delicious!");
    }

    public override string ToString()
    {
      return name;
    }
  }
}
