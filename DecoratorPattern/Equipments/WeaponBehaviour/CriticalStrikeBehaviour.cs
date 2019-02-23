using System;

namespace DecoratorPattern.Equipments.WeaponsBehaviour
{
    public class CriticalStrikeBehaviour : IWeaponBehaviour
    {
        public int CalculateDamage(int minimum)
        {
            int isCriticalStrike = new Random().Next(0, 101);

            if (isCriticalStrike > 70)
            {
                Console.WriteLine("Critical Strike!!!");
                return minimum * 3;
            }

            return minimum;
        }
    }
}
