using System;
using DecoratorPattern.Equipments.Weapons;

namespace DecoratorPattern.Equipments.Runes
{
    public class RuneDecorator : IWeapon
    {
        public IWeapon weapon;

        public RuneDecorator(IWeapon weapon) 
        {
            this.weapon = weapon;
            this.Behaviour = weapon.Behaviour;
            this.Name = weapon.Name;
        }
    }
}
