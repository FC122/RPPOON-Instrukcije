namespace AdapterRjesenje
{
    public class Arcane
    {
        public string ArcaneEffect()
        {
            return "Arcane Slash";
        }
    }
    public class ArcaneAdapter : IEffect
    {
        Arcane arcane;
        public ArcaneAdapter()
        {
            arcane = new Arcane();
        }
        public string GetEffect()
        {
            return arcane.ArcaneEffect();
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
            warrior.SwordSlash(new ArcaneAdapter());
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