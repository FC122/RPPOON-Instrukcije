namespace MetodaTvornicaZadatak
{
    class DragonDungeon
    {
        public void OpenDragonDungeon()
        {
            Console.WriteLine("Open Dragon Dungeon");
        }
    }
    class IceDungeon
    {
        public void OpenIceDungeon()
        {
            Console.WriteLine("Open Ice Dungeon");
        }
    }

    class Game
    {
        DragonDungeon dragonDungeon;
        IceDungeon iceDungeon;
        public void OpenDragonDungeon()
        {
            dragonDungeon = new DragonDungeon();
            if (iceDungeon == null)
            {
                dragonDungeon.OpenDragonDungeon();
            }
        }
        public void OpenIceDragonDungeon()
        {
            iceDungeon = new IceDungeon();
            if (dragonDungeon == null)
            {
                iceDungeon.OpenIceDungeon();
            }
        }
    }

    class GameManager
    {
        Game game = new Game();
        bool ui = true;//usualy we get data from ui
        public GameManager()
        {
            //if user gets from UI that player wants DragonDungeon
            if (ui)
            {
                game.OpenDragonDungeon();
            }
            else
            { //else user want ice dungeon
                game.OpenIceDragonDungeon();
            }
        }
    }

    class ClientCode
    {
        public static void Run()
        {
            GameManager gameManager = new GameManager();
        }
    }

}