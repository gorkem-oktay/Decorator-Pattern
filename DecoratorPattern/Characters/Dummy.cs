using System;
using DecoratorPattern.Observables;
using DecoratorPattern.Observers;

namespace DecoratorPattern.Characters
{
    public class Dummy : ICharacter
    {
        public Dummy() 
        {
            Name = "Dummy";
            Health = new Health(1000000);
            Health.AddObserver(new HealthBar(Type));
        }
    }
}
