using System;
using DecoratorPattern.Observables;
using DecoratorPattern.Weapons;

namespace DecoratorPattern.Characters
{
    public abstract class ICharacter
    {
        string mName;
        public string Name
        {
            set => mName = value;
            get => mName;
        }

        string mType;
        public string Type
        {
            set => mType = value;
            get => mType;
        }

        IWeapon mWeapon;
        public IWeapon Weapon
        {
            set => mWeapon = value;
            get => mWeapon;
        }

        Health mHealth;
        public Health Health
        {
            set => mHealth = value;
            get => mHealth;
        }

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
