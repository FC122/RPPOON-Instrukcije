namespace LanacOdgovornosti
{
    // Apstraktni handler
    abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    // Konkretni handler 1
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name} obradilo zahtjev {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    // Konkretni handler 2
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{this.GetType().Name} obradilo zahtjev {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    // Klijent
    class Client
    {
        public void Main()
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();

            handler1.SetSuccessor(handler2);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27 };

            foreach (int request in requests)
            {
                handler1.HandleRequest(request);
            }
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            Client client = new Client();
            client.Main();
        }
    }

}