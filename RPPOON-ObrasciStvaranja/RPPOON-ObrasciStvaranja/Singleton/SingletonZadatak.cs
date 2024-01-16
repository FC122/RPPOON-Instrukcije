namespace SingletonZadatak
{
    public class Game
    {
        public GameManager gm = GameManager.GetGameManager();
        public Game()
        {
            gm.GetConfigs();
        }
    }
    public class Character
    {
        public GameManager gm = GameManager.GetGameManager();
        public Character()
        {
            gm.GetCharacters();
        }
    }
    public class UI
    {
        public GameManager gm = GameManager.GetGameManager();
        public UI()
        {
            gm.GetUIElements();
        }
    }

    public class GameManager
    {
        private static GameManager gameManager;
        private GameManager()
        {

        }

        public static GameManager GetGameManager()
        {
            if (gameManager == null)
            {
                gameManager = new GameManager();
            }
            return gameManager;
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