using DecoratorPattern.Equipments.WeaponsBehaviour;

namespace DecoratorPattern.Equipments.Weapons
{
    public abstract class IWeapon : IEquipment
    {
        private int damage;
        public void SetDamage(int damage) => this.damage = damage;
        public virtual int GetDamage() => damage;

        public IWeaponBehaviour Behaviour { get; set; }

        public int CalculateDamage()
        {
            return Behaviour.CalculateDamage(GetDamage());
        }
    }
}
