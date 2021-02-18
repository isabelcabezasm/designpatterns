using System;
using System.Collections.Generic;

namespace ObserverSample
{
  public class Gordon : IObservable<Info>
  {
    // list of the current registered observers
    private List<IObserver<Info>> observers;
    private string name = "Gordon";

    public Gordon()
    {
      observers = new List<IObserver<Info>>();
    }

    // implementation of the Subscribe method: it returns an Unsubscriber object to allow the observer to unsubscribe on his own
    public IDisposable Subscribe(IObserver<Info> observer)
    {
      if (!observers.Contains(observer))
        observers.Add(observer);

      return new Unsubscriber(observers, observer);
    }

    public void GetInfo()
    {
      List<string> locations = new List<string>() { "Police station", "Witness house", "Gordon's office", "Crime scene" };
      List<string> hungerLevels = new List<string>() { "not hungry", "hungry", "starving" };

      foreach (string location in locations)
      {
        System.Threading.Thread.Sleep(2000);

        Random rnd = new Random();
        Info toBeSent = new Info(location, hungerLevels[rnd.Next(0, 3)]);

        // the subject sends the information to all the observers
        foreach (var observer in observers)
          observer.OnNext(toBeSent);
      }
    }

    public void PartyTime()
    {
      // in the end the subject notifies the completion to all the observers
      foreach (var observer in observers)
        observer.OnCompleted();
    }

    public void Hello()
    {
      Console.WriteLine($"Hello there, I'm {name} and I will keep Batman busy to help you guys organize his surprise party.");
    }
  }

  // this internal class is used to allow the observers to unsubscribe
  internal class Unsubscriber : IDisposable
  {
    private List<IObserver<Info>> _observers;
    private IObserver<Info> _observer;

    public Unsubscriber(List<IObserver<Info>> observers, IObserver<Info> observer)
    {
      this._observers = observers;
      this._observer = observer;
    }

    public void Dispose()
    {
      if (!(_observer == null)) _observers.Remove(_observer);
    }
  }

}
