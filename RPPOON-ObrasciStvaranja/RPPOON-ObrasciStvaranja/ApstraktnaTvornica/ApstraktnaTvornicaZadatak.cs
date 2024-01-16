namespace ApstraktnaTvornicaZadatak
{
    public class FireWizard
    {
        public void doFireMagic()
        {
            Console.WriteLine("Do Fire Magic");
        }
    }
    public class WaterWizard
    {
        public void doWaterMagic()
        {
            Console.WriteLine("Do Water Magic");
        }
    }
    public class FireGoblin
    {
        public void doFireDmg()
        {
            Console.WriteLine("Do Fire Dmg");
        }
    }
    public class WaterGoblin
    {
        public void doWaterDmg()
        {
            Console.WriteLine("Do Water Dmg");
        }
    }

    public class Game
    {
        FireGoblin fireGoblin = new FireGoblin();
        FireWizard fireWizard = new FireWizard();

        WaterGoblin waterGoblin = new WaterGoblin();
        WaterWizard waterWizard = new WaterWizard();

        public void Play()
        {
            fireGoblin.doFireDmg();
            waterGoblin.doWaterDmg();
            fireWizard.doFireMagic();
            waterWizard.doWaterMagic();
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