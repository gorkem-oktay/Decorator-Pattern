using System.Collections.Generic;
using DecoratorPattern.Observers;

namespace DecoratorPattern.Observables
{
    public abstract class IObservable
    {
        readonly List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyAll(object value)
        {
            foreach (IObserver observer in observers)
            {
                observer.Updated(this, value);
            }
        }
    }
}
