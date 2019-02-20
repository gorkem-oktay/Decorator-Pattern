namespace DecoratorPattern.Alchemy
{
    public class Water : IngredientDecorator
    {
        public Water(IPotion potion)
        {
            Potion = potion;
            Name = potion.Name;
            AddIngrediantName("Water");
        }

        public override int Cost()
        {
            return 1 + Potion.Cost();
        }
    }
}
