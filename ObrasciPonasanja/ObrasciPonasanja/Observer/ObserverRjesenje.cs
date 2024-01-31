namespace ObserverRjesenje
{
    public interface ILoggable
    {
        public void Log(string log);
    }

    public class UserConsole : ILoggable
    {
        public void Log(string log)
        {
            Console.WriteLine($"Write to user console: {log}");
        }
    }

    public class File : ILoggable
    {
        public void Log(string log)
        {
            Console.WriteLine($"Write log to file{log}");
        }
    }

    public class Email : ILoggable
    {
        public void Log(string log)
        {
            Console.WriteLine($"Send log to mail: {log}");
        }
    }

    public class LoggingManager
    {
        List<ILoggable> loggables = new List<ILoggable>();
        public void AddLoggable(ILoggable loggable)
        {
            loggables.Add(loggable);
        }
        public void RemoveLoggable(ILoggable loggable)
        {
            loggables.Remove(loggable);
        }

        public void LoggablesLog(string log)
        {
            loggables.ForEach(loggable =>
            {
                loggable.Log(log);
            });
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            LoggingManager loggingManager = new LoggingManager();
            loggingManager.AddLoggable(new UserConsole());
            loggingManager.AddLoggable(new Email());
            loggingManager.AddLoggable(new File());

            //some class does something and returns you string result
            loggingManager.LoggablesLog("Message from System");

        }
    }
}