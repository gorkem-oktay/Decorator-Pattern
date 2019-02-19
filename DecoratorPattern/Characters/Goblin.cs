using DecoratorPattern.Observables;
using DecoratorPattern.Observers;

namespace DecoratorPattern.Characters
{
    public class Goblin : ICharacter
    {
        public Goblin()
        {
            Type = "Goblin";
            Health = new Health(60);
            Health.AddObserver(new HealthBar(Type));
        }
    }
}
