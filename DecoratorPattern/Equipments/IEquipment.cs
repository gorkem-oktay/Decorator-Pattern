using System;
namespace DecoratorPattern.Equipments
{
    public abstract class IEquipment
    {
        public string Name { get; set; } = "Unknown Item";
    }
}
