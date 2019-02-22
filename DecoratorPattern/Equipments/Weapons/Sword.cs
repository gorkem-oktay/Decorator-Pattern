using DecoratorPattern.Equipments.WeaponsBehaviour;

namespace DecoratorPattern.Equipments.Weapons
{
    public class Sword : IWeapon
    {
        public Sword()
        {
            Name = "Sword";
            SetDamage(10);
            Behaviour = new SwordBehaviour();
        }
    }
}
