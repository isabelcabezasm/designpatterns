using System;

namespace ObserverSample
{
  public class Robin : IObserver<Info>
  {
    private string name = "Robin";
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

    public void BuyFood()
    {
      if (lastInfo.HungerLevel == "starving")
        Console.WriteLine($"{name}: I bought a lot of delicious food! Can last for weeks");
      else
        Console.WriteLine($"{name}: I bought some food, but we might order more pizza later");
    }

    public void CatchTheBadGuy()
    {
      Console.WriteLine($"{name}: I need to catch this bad guy! I'm going to unsubscribe");
      unsubscriber.Dispose();
    }

    public override string ToString()
    {
      return name;
    }
  }
}
