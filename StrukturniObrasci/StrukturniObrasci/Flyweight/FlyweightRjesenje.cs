namespace FlyweightRjesenje
{
    public class Weapon
    {
        string name;
        WeaponType weaponType;
        int dmg;

        public Weapon(int dmg, string name, WeaponType weaponType)
        {
            this.name = name;
            this.weaponType = weaponType;
            this.dmg = dmg;
            Console.WriteLine($"{dmg} {name} {weaponType.material} {weaponType.category}");
        }
        public void DoDmg()
        {
            weaponType.DoDmg(dmg);
        }

    }

    public class WeaponType
    {
        public string material;
        public string category;
        public WeaponType(string material, string category)
        {
            this.material = material;
            this.category = category;
        }
        public void DoDmg(int n)
        {
            Console.WriteLine("DoDmg" + n);
        }

    }

    public class WeaponFactory
    {
        public static Dictionary<string, WeaponType> weaponTypes
            = new Dictionary<string, WeaponType>();
        public static WeaponType GetWeaponType(String name)
        {
            return weaponTypes[name];
        }
    }

    public class Game
    {
        List<Weapon> weapons;
        public Game()
        {
            WeaponFactory.weaponTypes.Add("MetalSword", new WeaponType("Metal", "Sword"));
            WeaponFactory.weaponTypes.Add("WoodenBow", new WeaponType("Wooden", "Bow"));
            WeaponFactory.weaponTypes.Add("King Slayer", new WeaponType("Bronze", "Spear"));
            weapons = new List<Weapon>();
            for (int i = 0; i < 10; i++)
            {
                weapons.Add(new Weapon(10, "Excalibur", WeaponFactory.GetWeaponType("MetalSword")));
                weapons.Add(new Weapon(10, "God Killer", WeaponFactory.GetWeaponType("MetalSword")));
                weapons.Add(new Weapon(30, "King Slayer", WeaponFactory.GetWeaponType("MetalSword")));
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