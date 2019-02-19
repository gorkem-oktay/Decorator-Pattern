namespace DecoratorPattern.Weapons
{
    public class Club : IWeapon
    {
        public Club()
        {
            Type = "Club";
            Damage = 8;
            Behaviour = new ClubBehaviour();
        }
    }
}
