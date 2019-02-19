using DecoratorPattern.Observables;

namespace DecoratorPattern.Observers
{
    public interface IObserver
    {
        void Updated(IObservable observable, object value);
    }
}
