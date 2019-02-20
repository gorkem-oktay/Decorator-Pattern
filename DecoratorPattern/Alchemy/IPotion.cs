using System.Collections.Generic;

namespace DecoratorPattern.Alchemy
{
    public abstract class IPotion
    {
        public string Name { set; get; } = "Unknown Potion";

        public List<string> IngredientNames = new List<string>();

        public string GetDescription()
        {
            string ingredients = IngredientNames.Count > 0 ? IngredientNames[0] : "";
            for (int i = 1; i < IngredientNames.Count; i++) 
            {
                ingredients += ", " + IngredientNames[i];
            }
            return Name + ": " + ingredients;
        }

        public abstract int Cost();
    }
}
