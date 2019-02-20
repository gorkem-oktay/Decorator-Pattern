namespace DecoratorPattern.Alchemy
{
    public class ManaPotion : IPotion
    {
        public ManaPotion()
        {
            Name = "Mana Potion";
        }

        public override int Cost()
        {
            return 8;
        }
    }
}
