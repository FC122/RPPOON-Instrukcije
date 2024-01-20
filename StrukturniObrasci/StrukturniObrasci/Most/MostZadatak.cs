namespace MostZadatak
{
    public class SteelBow
    {
        public void ShootFireArrow(FireArrow fireArrow)
        {
            fireArrow.ShootArrow();
        }
        public void ShootRegularArrow(RegularArrow regularArrow)
        {
            regularArrow.ShootArrow();
        }
    }
    public class RegularArrow
    {
        public void ShootArrow()
        {
            Console.WriteLine("Shoot Regular Arrow");
        }
    }
    public class FireArrow
    {
        public void ShootArrow()
        {
            Console.WriteLine("Shoot Fire Arrow");
        }
    }

    public class Game
    {
        public Game()
        {
            SteelBow steelBow = new SteelBow();
            steelBow.ShootFireArrow(new FireArrow());
            steelBow.ShootRegularArrow(new RegularArrow());
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