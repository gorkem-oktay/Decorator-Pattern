using DecoratorPattern.Equipments.WeaponsBehaviour;

namespace DecoratorPattern.Equipments.Weapons
{
    public class Dagger : IWeapon
    {
        public Dagger()
        {
            Name = "Dagger";
            SetDamage(4);
            Behaviour = new DaggerBehaviour();
        }
    }
}
