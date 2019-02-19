using System;
namespace DecoratorPattern.Alchemy
{
    public abstract class IngredientDecorator : IPotion
    {
        public abstract string GetName();
    }
}
