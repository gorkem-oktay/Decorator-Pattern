using System;
using DecoratorPattern.Equipments.Weapons;

namespace DecoratorPattern.Equipments.Runes
{
    public class DamageRune : WeaponRuneDecorator
    {
        public DamageRune(IWeapon weapon) : base(weapon) 
        {
            Console.WriteLine("Added Damage Rune to " + Name);
        }

        public override int GetDamage()
        {
            return weapon.GetDamage() + 2;
        }
    }
}
