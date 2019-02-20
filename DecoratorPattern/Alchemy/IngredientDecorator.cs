namespace DecoratorPattern.Alchemy
{
    public abstract class IngredientDecorator : IPotion
    {
        public IPotion Potion;

        public void AddIngrediantName(string name) 
        {
            IngredientNames = Potion.IngredientNames;
            IngredientNames.Add(name);
        }
    }
}
