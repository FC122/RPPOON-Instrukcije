namespace SingletonRjesenje
{
    public class Game
    {
        public GameManager gm = GameManager.GetInstance();
        public Game()
        {
            gm.GetConfigs();
        }
    }
    public class Character
    {
        public GameManager gm = GameManager.GetInstance();
        public Character()
        {
            gm.GetCharacters();
        }
    }
    public class UI
    {
        public GameManager gm = GameManager.GetInstance();
        public UI()
        {
            gm.GetUIElements();
        }
    }
    public class GameManager
    {
        private static GameManager gm;
        private GameManager()
        {//get configs, ui and characters
        }
        public static GameManager GetInstance()
        {
            if (gm == null)
            {
                gm = new GameManager();
            }
            return gm;
        }
        public void GetConfigs()
        {
            Console.WriteLine("Configs");
        }
        public void GetUIElements()
        {
            Console.WriteLine("UI Elements");
        }
        public void GetCharacters()
        {
            Console.WriteLine("Characters");
        }
    }

    public class ClientCode
    {
        public static void Run()
        {
            new Game();
            new UI();
            new Character();
        }
    }
}