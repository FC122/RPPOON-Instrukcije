namespace LanacOdgovornostiZadatak
{
    public class GameEvent
    {
        public string EventType { get; set; }

        public GameEvent(string eventType)
        {
            EventType = eventType;
        }
    }

    public interface IEventHandler
    {
        public void HandleEvent(GameEvent gameEvent);
    }

    class KeyboardHandler
    {
        public void HandleEvent(GameEvent gameEvent)
        {
            Console.WriteLine("KeyboardHandler handled KeyPress event");
        }
    }

    class MouseHandler : IEventHandler
    {
        public void HandleEvent(GameEvent gameEvent)
        {
            Console.WriteLine("MouseHandler handled MouseClick event");
        }
    }

    class CollisionHandler : IEventHandler
    {
        public void HandleEvent(GameEvent gameEvent)
        {
            Console.WriteLine("CollisionHandler handled Collision event");
        }
    }

    public class Game
    {
        public Game()
        {
            GameEvent gameEvent = new GameEvent("Collision");

            if (gameEvent.EventType == "Collision")
            {
                new CollisionHandler().HandleEvent(gameEvent);
            }
            else if (gameEvent.EventType == "KeyPress")
            {
                new KeyboardHandler().HandleEvent(gameEvent);
            }
            else if (gameEvent.EventType == "MouseClick")
            {
                new MouseHandler().HandleEvent(gameEvent);
            }
            //new GameEvent("KeyPress")
            //new GameEvent("MouseClick")
            //new GameEvent("Collision")
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