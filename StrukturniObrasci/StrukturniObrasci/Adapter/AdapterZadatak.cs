namespace AdapterZadatak
{
    public class Arcane
    {
        //You want warrior to use Arcane effect but you cant change Arcane class
        //you cant make it implement IEffect?
        //use adapter to make Warrior use arcane effect
        public string ArcaneEffect()
        {
            return "Arcane Slash";
        }
    }

    public class Warrior
    {
        public void SwordSlash(IEffect effect)
        {
            Console.WriteLine(effect.GetEffect() + " Slash");
        }
    }
    public interface IEffect
    {
        public string GetEffect();
    }

    public class Strength : IEffect
    {
        public string GetEffect()
        {
            return "Super Strength";
        }
    }

    public class Game
    {
        public Warrior warrior = new Warrior();
        public Game()
        {
            //How will you use Arcane effect if you cant change Arcane Class
            warrior.SwordSlash(new Strength());
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            new Game();
        }
    }
}