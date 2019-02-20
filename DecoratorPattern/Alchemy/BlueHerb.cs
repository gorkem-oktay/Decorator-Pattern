namespace DecoratorPattern.Alchemy
{
    public class BlueHerb : IngredientDecorator
    {
        public BlueHerb(IPotion potion)
        {
            Potion = potion;
            Name = potion.Name;
            AddIngrediantName("Blue Herb");
        }

        public override int Cost()
        {
            return 3 + Potion.Cost();
        }
    }
}
