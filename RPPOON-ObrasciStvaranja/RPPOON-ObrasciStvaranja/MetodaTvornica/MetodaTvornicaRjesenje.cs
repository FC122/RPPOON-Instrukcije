namespace MetodaTvornicaRjesenje
{
    abstract class Dungeon { public abstract void Open(); }

    class DragonDungeon : Dungeon//konkretan proizvod
    {
        public DragonDungeon() { Open(); }
        public override void Open()
        {
            Console.WriteLine("Open Dragon Dungeon");
        }
    }

    class IceDungeon : Dungeon//konkretan proizvod
    {
        public IceDungeon() { Open(); }
        public override void Open()
        {
            Console.WriteLine("Open Ice Dungeon");
        }
    }

    abstract class DungeonSpawner
    {//Tvornica
        public abstract Dungeon SpawnDungeon();
    }

    class IceDungeonSpawner : DungeonSpawner//Konkretna Tvornica
    {
        public override Dungeon SpawnDungeon()
        {//Metoda stvaranja
            return new IceDungeon();
        }//stvaranje objekta
    }

    class DragonDungeonSpawner : DungeonSpawner//Konkretna Tvornica
    {
        public override Dungeon SpawnDungeon()
        {//Metoda stvaranja
            return new DragonDungeon();
        }//stvaranje objekta
    }

    class Game
    {
        //game doesnt have to care about what dungeon it is working with
        Dungeon dungeon;
        public void OpenDungeon(DungeonSpawner spawner)
        {
            dungeon = spawner.SpawnDungeon();
            dungeon.Open();
        }
    }

    class GameManager
    {
        Game game = new Game();
        public GameManager(string dungeonConfig)
        {
            if (dungeonConfig == "Dragon")
            {
                game.OpenDungeon(new DragonDungeonSpawner());
            }
            else if (dungeonConfig == "Ice")
            {
                game.OpenDungeon(new IceDungeonSpawner());
            }
        }
    }

    class ClientCode
    {
        public static void Run()
        {
            GameManager gameManager = new GameManager("Dragon");
        }
    }
}