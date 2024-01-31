namespace GraditeljTest
{
    public class Adventure{
        Weapon weapon;
        Character character;
        Potion potion;
        public Adventure(Weapon weapon, Character character, Potion potion){
            this.weapon = weapon;
            this.character = character;
            this.potion = potion;
        }
        public void embark(){}
    }
    public class AdventureCreator{
        public void ResetAdventure(){}
    }
    public class Tavern{
        AdventureCreator adventureCreator;
        public Tavern(AdventureCreator adventureCreator){
            this.adventureCreator = adventureCreator;
        }
        public Adventure PrepareWarriorAdventure(){}
        public Adventure PrepareArcherAdventure(){}
    }
}