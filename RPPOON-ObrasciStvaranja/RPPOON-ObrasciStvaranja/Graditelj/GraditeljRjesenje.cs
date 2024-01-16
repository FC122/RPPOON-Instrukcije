namespace GraditeljRjesenje
{
    public interface Type { }//Dio Proizvoda
    public class Fire : Type { }
    public class Water : Type { }

    public interface Species { }//Dio Proizvoda
    public class Human : Species { }
    public class Elf : Species { }
    public class Dwarf : Species { }

    public interface Armor { }//Dio Proizvoda
    public class SteelArmor : Armor { }
    public class LeatherArmor : Armor { }

    public class Player//Proizvod
    {
        public Type type { get; set; }
        public Species species { get; set; }
        public Armor armor { get; set; }
        public void play()
        {
        }
    }

    public interface PlayerBuilder//Apstrakcija Graditelja
    {
        public Builder Type(Type type);
        public Builder Armor(Armor armor);
        public Builder Species(Species species);
        public void Reset();
    }

    public class Builder : PlayerBuilder//Konkretan Graditelj 
    {
        Player player;
        public Builder() { player = new Player(); }
        public Builder Armor(Armor armor)
        {
            player.armor = armor;
            return this;
        }
        public void Reset() { player = new Player(); }
        public Builder Species(Species species)
        {
            player.species = species;
            return this;
        }
        public Builder Type(Type type)
        {
            player.type = type;
            return this;
        }
        public Player Build()
        {
            Player player = this.player;
            Reset();
            return player;
        }
    }

    public class Direktor//Direktor
    {
        PlayerBuilder builder;
        public Direktor(PlayerBuilder builder)
        {
            this.builder = builder;
        }
        public Player GetFireDwarf()
        {
            return builder.Type(new Fire()).Species(new Dwarf()).Build();
        }
        public Player GetWaterElf()
        {
            return builder.Type(new Water()).Species(new Elf()).Build();
        }
    }

    public class Game//Klijentski kod
    {
        PlayerBuilder builder;
        Direktor direktor;
        public void Play()
        {
            builder = new Builder();
            direktor = new Direktor(builder);
            Player fireDwarf = direktor.GetFireDwarf();
        }
    }

    public class ClientCode
    {
        public static void Run()
        {
            Game game = new Game();
            game.Play();
        }
    }
}