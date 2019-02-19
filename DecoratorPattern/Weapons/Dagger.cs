namespace DecoratorPattern.Weapons
{
    public class Dagger : IWeapon
    {
        public Dagger()
        {
            Type = "Dagger";
            Damage = 4;
            Behaviour = new DaggerBehaviour();
        }
    }
}
