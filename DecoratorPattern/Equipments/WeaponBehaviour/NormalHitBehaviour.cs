namespace DecoratorPattern.Equipments.WeaponsBehaviour
{
    public class NormalHitBehaviour : IWeaponBehaviour
    {
        public int CalculateDamage(int minimum)
        {
            return minimum;
        }
    }
}
