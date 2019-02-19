using System;
namespace DecoratorPattern.Alchemy
{
    public class GreenHerb : IngredientDecorator
    {
        IPotion potion;

        public GreenHerb(IPotion potion)
        {
            this.potion = potion;
        }

        public override int Cost()
        {
            return 2;
        }

        public override string GetName()
        {
            return potion.Name + ", Green Herb";
        }
    }
}
