using System;

namespace ObserverSample
{
  public class Catwoman : IObserver<Info>
  {
    private string name = "Catwoman";
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

      Console.WriteLine($"{name}: Latest info from Gordon -> I only care about the location: {value.CurrentLocation}");
      lastInfo = value;
    }

    public void BuyDrinks()
    {
      Console.WriteLine($"{name}: I bought so many drinks, it will be fun!");
    }

    public override string ToString()
    {
      return name;
    }
  }
}
