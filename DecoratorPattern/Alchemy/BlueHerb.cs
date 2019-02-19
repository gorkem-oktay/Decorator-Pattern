using System;
namespace DecoratorPattern.Alchemy
{
    public class BlueHerb : IngredientDecorator
    {
        IPotion potion;

        public BlueHerb(IPotion potion)
        {
            this.potion = potion;
        }

        public override int Cost()
        {
            return 3;
        }
    }
}
