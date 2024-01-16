namespace GraditeljZadatak
{

    public interface Type { }
    public class Fire : Type { }
    public class Water : Type { }

    public interface Species { }
    public class Human : Species { }
    public class Elf : Species { }
    public class Dwarf : Species { }

    public interface Armor { }
    public class SteelArmor : Armor { }
    public class LeatherArmor : Armor { }

    public class Player
    {
        Type type;
        Species species;
        Armor armor;
        public Player(Type type, Species species, Armor armor)
        {
            this.type = type;
            this.species = species;
            this.armor = armor;
        }
        public void play()
        {
        }
    }
    public class Game
    {
        Player steelDwarf = new Player(new Fire(), new Dwarf(), new SteelArmor());
    }

    public class ClientCode
    {
        public static void Run()
        {
        }
    }
}