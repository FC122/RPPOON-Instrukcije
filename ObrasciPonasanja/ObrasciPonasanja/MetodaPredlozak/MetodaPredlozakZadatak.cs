namespace MetodaPredlozakZadatak
{
    public class Game
    {
        public Game()
        {
            Console.WriteLine("Start Game");
            Console.WriteLine("Spawn Enemy");
            Console.WriteLine("Spawn a Player");
            Console.WriteLine("End Game");
        }
    }
    public class GameManager
    {
        Game game;
        public GameManager(Game game)
        {
            this.game = game;
        }
    }
    public static class ClientCode
    {
        public static void Run()
        {
            new GameManager(new Game());
        }
    }
}