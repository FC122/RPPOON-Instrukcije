namespace PrototipExtraZadatak
{

    interface Champion
    {
        public void Attack();
    }

    public class Assassin : Champion
    {
        string ability;
        public Assassin(string ability)
        {
            this.ability = ability;
        }
        public void Attack()
        {
            Console.WriteLine($"Attack - {ability}");
        }
    }

    public class Mech : Champion
    {
        string specialEffect;
        public Mech(string specialEffect)
        {
            this.specialEffect = specialEffect;
        }
        public void Attack()
        {
            Console.WriteLine($"Attack - {specialEffect}");
        }
    }

    public static class Helper
    {
        public static string ReturnRandomEffect()
        {
            Random random = new Random();
            switch (random.Next(1, 5))
            {
                case 1:
                    return "Fire";
                case 2:
                    return "Water";
                case 3:
                    return "Air";
                case 4:
                    return "Electro";
                default:
                    return "No Efect";
            }
        }
        public static string ReturnRandomAbility()
        {
            Random random = new Random();
            switch (random.Next(1, 5))
            {
                case 1:
                    return "Shadow Walk";
                case 2:
                    return "Stab";
                case 3:
                    return "Kick";
                case 4:
                    return "Punch";
                default:
                    return "No Ability";
            }
        }
    }

    public class Game
    {
        List<Champion> champions = new List<Champion>()
        {new Mech(Helper.ReturnRandomEffect()),
        new Assassin(Helper.ReturnRandomAbility())};
        public void DuplicateChampions()
        {
            champions.Add(new Mech(Helper.ReturnRandomEffect()));
            champions.Add(new Assassin(Helper.ReturnRandomAbility()));
        }
        public void AttackAll()
        {
            champions.ForEach(champion =>
            {
                champion.Attack();
            });
        }
    }

    public class ClientCode
    {
        public static void Run()
        {
            Game game = new Game();
            game.DuplicateChampions();
            game.AttackAll();
        }
    }
}