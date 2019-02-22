namespace DecoratorPattern.Equipments.WeaponsBehaviour
{
    public class ClubBehaviour : IWeaponBehaviour
    {
        public int CalculateDamage(int minimum)
        {
            return minimum;
        }
    }
}
