namespace DecoratorPattern.Alchemy
{
    public class Vial : IngredientDecorator
    {
        public Vial(IPotion potion)
        {
            Potion = potion;
            Name = potion.Name;
            AddIngrediantName("Vial");
        }

        public override int Cost()
        {
            return 4 + Potion.Cost();
        }
    }
}
