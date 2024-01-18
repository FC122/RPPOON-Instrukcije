namespace AdapterRjesenjeDva
{
    public class ChatGPT
    {
        //how do you make ChatGPT talk with the messenger app?
        //implement adapter
        public string Talk()
        {
            return "Valid Text From ChatGPT";
        }
    }
    public interface IMessage
    {
        public void SendMessage();

        public void ReceiveMessage();
    }

    public class ChatGPTAdapter : IMessage
    {
        ChatGPT chatGPT = new ChatGPT();
        public void ReceiveMessage()
        {
            Console.WriteLine("GPT Message " + chatGPT.Talk());
        }
        public void SendMessage()
        {
            Console.WriteLine("GPT Response" + chatGPT.Talk());
        }
    }

    public class MessengerApp : IMessage
    {
        string userName;
        public MessengerApp(string userName)
        {
            this.userName = userName;
        }
        public void SendMessage()
        {
            Console.WriteLine(userName + " sent a Valid message");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine(userName + " received a Valid message");
        }
    }

    public class MessagingSession
    {
        IMessage userOne;
        IMessage userTwo;

        public MessagingSession(IMessage userOne, IMessage userTwo)
        {
            this.userOne = userOne;
            this.userTwo = userTwo;
            while (true)
            {
                userOne.ReceiveMessage();
                Thread.Sleep(3000);
                userOne.SendMessage();
                Thread.Sleep(3000);
                userTwo.ReceiveMessage();
                Thread.Sleep(3000);
                userTwo.SendMessage();
            }
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            new MessagingSession(new MessengerApp("Marko"), new ChatGPTAdapter());
        }
    }
}