namespace DekoraterExtraZadatak
{
    public class Noodles
    {
        public void AddNoddles()
        {
            Console.WriteLine("Add Noodles");
        }
    }

    public class Beef
    {
        public void AddBeef()
        {
            Console.WriteLine("Add Beef");
        }
    }

    public class Mushrooms
    {
        public void AddMushrooms()
        {
            Console.WriteLine("Add Mushrooms");
        }
    }

    public class Water
    {
        public void AddWater()
        {
            Console.WriteLine("Add Water");
        }
    }

    public class Meal
    {
        Beef beef;
        Mushrooms mushrooms;
        Noodles noodles;
        Water water;
        public Meal()
        {
            beef = new Beef();
            mushrooms = new Mushrooms();
            noodles = new Noodles();
            water = new Water();
        }
        public void MakeMushroomNoodleSoup()
        {
            water.AddWater();
            mushrooms.AddMushrooms();
            noodles.AddNoddles();
        }

        public void MakeBeefNoodleSoup()
        {
            water.AddWater();
            beef.AddBeef();
            noodles.AddNoddles();
        }

        public void MakeMushroomBeefSoup()
        {
            water.AddWater();
            beef.AddBeef();
            mushrooms.AddMushrooms();
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            new Meal().MakeBeefNoodleSoup();
        }
    }
}