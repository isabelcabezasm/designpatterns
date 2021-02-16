using System;

namespace ObserverSample
{
  public class Batgirl : IObserver<Info>
  {
    private string name = "Batgirl";
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

    public void BuyBalloons()
    {
      Console.WriteLine($"{name}: I bought hundreds of colorful balloons");
    }

    public void BuyPresents()
    {
      Console.WriteLine($"{name}: I found the most beatiful presents! Batman will be happy");
    }

    public override string ToString()
    {
      return name;
    }
  }
}
