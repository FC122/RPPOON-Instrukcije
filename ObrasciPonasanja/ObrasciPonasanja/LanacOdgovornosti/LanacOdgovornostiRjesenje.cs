namespace LanacOdgovornostiRjesenje
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
        public void SetSuccessor(IEventHandler eventHandler);
        public void HandleEvent(GameEvent gameEvent);
    }

    public class BaseHandler : IEventHandler
    {
        protected IEventHandler successor;
        private IEventHandler last;
        public virtual void HandleEvent(GameEvent gameEvent)
        {
            if (successor != null)
            {
                successor.HandleEvent(gameEvent);
            }
        }

        public void SetSuccessor(IEventHandler eventHandler)
        {
            if (successor == null)
            {
                successor = eventHandler;
                last = successor;
            }
            else
            {
                last.SetSuccessor(eventHandler);
                last = eventHandler;
            }
        }
    }

    class KeyboardHandler : BaseHandler
    {
        public override void HandleEvent(GameEvent gameEvent)
        {
            if (gameEvent.EventType == "KeyPress")
            {
                Console.WriteLine("KeyboardHandler handled KeyPress event");
            }
            else
            {
                Console.WriteLine("KeyboardHandler passed the event to the next handler");
                successor.HandleEvent(gameEvent);
            }
        }
    }

    class MouseHandler : BaseHandler
    {
        public override void HandleEvent(GameEvent gameEvent)
        {
            if (gameEvent.EventType == "MouseClick")
            {
                Console.WriteLine("MouseHandler handled MouseClick event");
            }
            else
            {
                Console.WriteLine("MouseHandler passed the event to the next handler");
                successor.HandleEvent(gameEvent);
            }
        }
    }

    class CollisionHandler : BaseHandler
    {
        public override void HandleEvent(GameEvent gameEvent)
        {
            if (gameEvent.EventType == "Collision")
            {
                Console.WriteLine("CollisionHandler handled Collision event");
            }
            else
            {
                Console.WriteLine("CollisionHandler cannot handle this event");
                successor.HandleEvent(gameEvent);
            }
        }
    }

    public class Game
    {
        public Game()
        {
            // Creating event handlers
            IEventHandler keyboardHandler = new KeyboardHandler();

            IEventHandler mouseHandler = new MouseHandler();
            IEventHandler collisionHandler = new CollisionHandler();
            IEventHandler baseHandler = new BaseHandler();

            baseHandler.SetSuccessor(keyboardHandler);
            baseHandler.SetSuccessor(mouseHandler);
            baseHandler.SetSuccessor(collisionHandler);

            baseHandler.HandleEvent(new GameEvent("Collision"));
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
