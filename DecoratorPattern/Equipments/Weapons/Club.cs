using DecoratorPattern.Equipments.WeaponsBehaviour;

namespace DecoratorPattern.Equipments.Weapons
{
    public class Club : IWeapon
    {
        public Club()
        {
            Name = "Club";
            SetDamage(8);
            Behaviour = new ClubBehaviour();
        }
    }
}
