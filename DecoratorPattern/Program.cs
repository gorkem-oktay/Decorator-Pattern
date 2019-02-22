using System;
using DecoratorPattern.Characters;
using DecoratorPattern.Equipments.Runes;
using DecoratorPattern.Equipments.Weapons;

namespace DecoratorPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ICharacter ourKnight = new Knight
            {
                Name = "Zafiru",
                Weapon = new Dagger()
            };

            Console.WriteLine(ourKnight.Name + ", travels across countries to live an adventures life...");
            Console.WriteLine();

            ICharacter evilGoblin = new Goblin
            {
                Weapon = new Club()
            };

            Console.WriteLine("Than suddenly a " + evilGoblin.Type + " appears.");
            Console.WriteLine("And attacks " + ourKnight.Name);

            evilGoblin.Hit(ourKnight);

            Console.WriteLine(ourKnight.Name + " tries to fight back");

            ourKnight.Hit(evilGoblin);

            Console.WriteLine("But he couldn't inflict much damage");
            Console.WriteLine("then he saw a sword on the ground and grabs it");

            ourKnight.Weapon = new Sword();

            Console.WriteLine("And fearlessly attack " + evilGoblin.Type);

            ourKnight.Hit(evilGoblin);

            Console.WriteLine();
            Console.WriteLine("After defeating " + evilGoblin.Type);
            Console.WriteLine(ourKnight.Name + " stops at the blacksmith to upgrade his sword");
            Console.WriteLine("Then buys three damage rune and goes to training ground to test them");
            Console.WriteLine();

            ICharacter dummy = new Dummy();

            ourKnight.Weapon = new DamageRune(ourKnight.Weapon);
            ourKnight.Hit(dummy);
            ourKnight.Weapon = new DamageRune(ourKnight.Weapon);
            ourKnight.Hit(dummy);
            ourKnight.Weapon = new DamageRune(ourKnight.Weapon);
            ourKnight.Hit(dummy);
        }
    }
}
