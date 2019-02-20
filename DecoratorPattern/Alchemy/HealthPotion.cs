namespace DecoratorPattern.Alchemy
{
    public class HealthPotion : IPotion
    {
        public HealthPotion()
        {
            Name = "Health Potion";
        }

        public override int Cost()
        {
            return 8;
        }
    }
}
