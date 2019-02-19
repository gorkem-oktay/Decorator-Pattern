namespace DecoratorPattern.Weapons
{
    public class Sword : IWeapon
    {
        public Sword()
        {
            Type = "Sword";
            Damage = 10;
            Behaviour = new SwordBehaviour();
        }
    }
}
