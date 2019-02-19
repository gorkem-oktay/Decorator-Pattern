using System;
namespace DecoratorPattern.Alchemy
{
    public abstract class IPotion
    {
        string mName = "Unknown Potion";
        public string Name 
        {
            set => mName = value;
            get => mName;
        }

        public abstract int Cost();
    }
}
