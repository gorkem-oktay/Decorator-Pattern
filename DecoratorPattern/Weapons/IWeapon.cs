namespace DecoratorPattern.Weapons
{
    public abstract class IWeapon
    {
        string mType = "Unknown Type";
        public string Type
        {
            set => mType = value;
            get => mType;
        }

        int mDamage;
        public int Damage
        {
            set => mDamage = value;
            get => mDamage;
        }

        IWeaponBehaviour mBehaviour;
        public IWeaponBehaviour Behaviour
        {
            set => mBehaviour = value;
            get => mBehaviour;
        }

        public int CalculateDamage()
        {
            return Behaviour.CalculateDamage(Damage);
        }
    }
}
