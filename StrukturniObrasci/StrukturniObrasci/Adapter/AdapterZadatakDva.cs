namespace AdapterZadatakDva
{
    //you cant change this class
    public class ChatGPT
    {
        //how do you make ChatGPT talk with the messenger app?
        //implement adapter
        public string Talk()
        {
            return "Valid Text From ChatGPT";
        }
    }

    public class MessengerApp
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
        MessengerApp userOne;
        MessengerApp userTwo;

        public MessagingSession(MessengerApp userOne, MessengerApp userTwo)
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
            new MessagingSession(new MessengerApp("Marko"), new MessengerApp("Laura"));
        }
    }
}