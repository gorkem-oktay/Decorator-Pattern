using System;
namespace DecoratorPattern.Alchemy
{
    public class Vial : IngredientDecorator
    {
        IPotion potion;

        public Vial(IPotion potion)
        {
            this.potion = potion;
        }

        public override int Cost()
        {
            return 4 + potion.Cost();
        }
    }
}
