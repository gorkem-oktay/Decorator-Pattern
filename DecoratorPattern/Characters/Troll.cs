using DecoratorPattern.Observables;
using DecoratorPattern.Observers;

namespace DecoratorPattern.Characters
{
    public class Troll : ICharacter
    {
        public Troll()
        {
            Type = "Troll";
            Health = new Health(140);
            Health.AddObserver(new HealthBar(Type));
        }
    }
}
