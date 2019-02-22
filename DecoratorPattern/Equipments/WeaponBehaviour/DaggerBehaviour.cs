using System;

namespace DecoratorPattern.Equipments.WeaponsBehaviour
{
    public class DaggerBehaviour : IWeaponBehaviour
    {
        public int CalculateDamage(int minimum)
        {
            int isDoubleStrike = new Random().Next(0, 101);

            if (isDoubleStrike > 30)
            {
                Console.WriteLine("Double Strike!!!");
                return minimum * 2;
            }

            return minimum;
        }
    }
}
