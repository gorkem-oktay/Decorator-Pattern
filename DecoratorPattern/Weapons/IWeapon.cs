namespace DecoratorPattern.Weapons
{
    public abstract class IWeapon
    {
        public string Type { get; set; } = "Unknown Type";
        public int Damage { get; set; } = 0;
        public IWeaponBehaviour Behaviour { get; set; }

        public int CalculateDamage()
        {
            return Behaviour.CalculateDamage(Damage);
        }
    }
}
