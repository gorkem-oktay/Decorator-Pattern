namespace DecoratorPattern.Weapons
{
    public class ClubBehaviour : IWeaponBehaviour
    {
        public int CalculateDamage(int minimum)
        {
            return minimum;
        }
    }
}
