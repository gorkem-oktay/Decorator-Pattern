using DecoratorPattern.Observables;
using DecoratorPattern.Observers;

namespace DecoratorPattern.Characters
{
    public class Knight : ICharacter
    {
        public Knight()
        {
            Type = "Knight";
            Health = new Health(100);
            Health.AddObserver(new HealthBar(Type));
        }
    }
}
