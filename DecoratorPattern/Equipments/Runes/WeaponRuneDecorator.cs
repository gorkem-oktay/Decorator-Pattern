using System;
using DecoratorPattern.Equipments.Weapons;

namespace DecoratorPattern.Equipments.Runes
{
    // Decorator interface
    public class WeaponRuneDecorator : IWeapon
    {
        public IWeapon weapon;

        public WeaponRuneDecorator(IWeapon weapon) 
        {
            this.weapon = weapon;
            this.Behaviour = weapon.Behaviour;
            this.Name = weapon.Name;
        }
    }
}
