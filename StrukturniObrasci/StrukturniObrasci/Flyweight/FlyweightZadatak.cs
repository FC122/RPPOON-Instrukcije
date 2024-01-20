namespace FlyweightZadatak
{
    public class Weapon
    {
        string name;
        string material;
        string category;
        int dmg;
        public Weapon(int dmg, string name, string material, string category)
        {
            this.name = name;
            this.material = material;
            this.category = category;
            this.dmg = dmg;
            Console.WriteLine($"{dmg} {name} {material} {category}");
        }
    }

    public class Game
    {
        List<Weapon> weapons;
        public Game()
        {
            weapons = new List<Weapon>();
            for (int i = 0; i < 10; i++)
            {
                weapons.Add(new Weapon(10, "Excalibur", "Metal", "Sword"));
                weapons.Add(new Weapon(15, "God Killer", "Wooden", "Bow"));
                weapons.Add(new Weapon(30, "King Slayer", "Bronze", "Spear"));
            }
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