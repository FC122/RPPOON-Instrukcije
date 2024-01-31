namespace GraditeljTest
{
    public interface Weapon { }
    public class Sword : Weapon { }
    public class Bow : Weapon { }

    public interface Character { }
    public class Warrior : Character { }
    public class Archer : Character { }

    public interface Potion { }
    public class HealthPotion : Potion { }
    public class ManaPotion : Potion { }

    public class Adventure
    {
        Weapon weapon;
        Character character;
        Potion potion;

        public Adventure(Weapon weapon, Character character, Potion potion)
        {
            this.weapon = weapon;
            this.character = character;
            this.potion = potion;
        }

        public void embark()
        {
            // Logika za započinjanje avanture
        }
    }

    public class AdventureBuilder
    {
        Weapon weapon;
        Character character;
        Potion potion;

        public AdventureBuilder ChooseWeapon(Weapon weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public AdventureBuilder ChooseCharacter(Character character)
        {
            this.character = character;
            return this;
        }

        public AdventureBuilder ChoosePotion(Potion potion)
        {
            this.potion = potion;
            return this;
        }

        public Adventure Build()
        {
            return new Adventure(weapon, character, potion);
        }
    }

    public class Tavern
    {
        AdventureBuilder adventureBuilder;

        public Tavern(AdventureBuilder adventureBuilder)
        {
            this.adventureBuilder = adventureBuilder;
        }

        public Adventure PrepareWarriorAdventure()
        {
            return adventureBuilder.ChooseCharacter(new Warrior())
                                  .ChooseWeapon(new Sword())
                                  .ChoosePotion(new HealthPotion())
                                  .Build();
        }

        public Adventure PrepareArcherAdventure()
        {
            return adventureBuilder.ChooseCharacter(new Archer())
                                  .ChooseWeapon(new Bow())
                                  .ChoosePotion(new ManaPotion())
                                  .Build();
        }
    }

    public class ClientCode
    {
        public static void Run()
        {
            AdventureBuilder adventureBuilder = new AdventureBuilder();
            Tavern tavern = new Tavern(adventureBuilder);

            Adventure warriorAdventure = tavern.PrepareWarriorAdventure();
            Adventure archerAdventure = tavern.PrepareArcherAdventure();

            // Ovdje možete koristiti avanture prema potrebama igre
        }
    }
}