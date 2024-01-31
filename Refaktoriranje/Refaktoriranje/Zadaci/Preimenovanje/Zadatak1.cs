namespace PreimenovanjeZadatak
{
    enum Priority { Low, High, Critical }
    class Message
    {
        public string Author { get; private set; }
        public string Content { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Priority Priority { get; private set; }
        public Message(string author, string content, DateTime createdAt, Priority priority)
        {
            Author = author;
            Content = content;
            CreatedAt = createdAt;
            Priority = priority;
        }
        public override string ToString() { return "not implemented"; }
    }

    class Logger
    {
        static void LogMessage(Message message)
        {
            Console.WriteLine(message);
        }
    }
}
