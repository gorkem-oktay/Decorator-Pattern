using System;
using DecoratorPattern.Observables;

namespace DecoratorPattern.Observers
{
    public class HealthBar : IObserver
    {
        String mName;
        public String Name
        {
            set => mName = value;
            get => mName;
        }

        public HealthBar(String name)
        {
            Name = name;
        }

        public void Updated(IObservable observable, object value)
        {
            if (observable.GetType() == typeof(Health))
            {
                Health health = (Health)observable;
                Console.WriteLine(Name + " received " + value + " damage and " + health.Value + " health left");
            }
        }
    }
}
