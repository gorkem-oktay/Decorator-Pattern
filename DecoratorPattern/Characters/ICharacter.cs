using System;
using DecoratorPattern.Equipments.Weapons;
using DecoratorPattern.Observables;

namespace DecoratorPattern.Characters
{
    public abstract class ICharacter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public IWeapon Weapon { get; set; }
        public Health Health { get; set; }

        public void Hit(ICharacter to)
        {
            if (Weapon != null)
            {
                int damage = Weapon.CalculateDamage();
                to.Health.Decrease(damage);
            }
            else
            {
                Console.WriteLine("No equipped weapon");
            }
        }
    }
}
