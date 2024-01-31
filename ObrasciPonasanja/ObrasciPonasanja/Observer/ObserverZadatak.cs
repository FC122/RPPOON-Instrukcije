namespace ObserverZadatak
{
    public interface ILoggable
    {
        public void Log(string message);
    }

    public class UserConsole : ILoggable
    {
        public void Log(string message)
        {
            ShowMessageOnConsole(message);
        }

        public void ShowMessageOnConsole(string message)
        {
            Console.WriteLine($"Write to user console: {message}");
        }
    }

    public class File : ILoggable
    {
        public void Log(string message)
        {
            SaveLogToFile(message);
        }

        public void SaveLogToFile(string log)
        {
            Console.WriteLine($"Write log to file{log}");
        }
    }

    public class Email : ILoggable
    {
        public void Log(string message)
        {
            SendMail(message);
        }

        public void SendMail(string mailContent)
        {
            Console.WriteLine($"Send log to mail: {mailContent}");
        }
    }

    public interface ILogManageable
    {
        public void Add(ILoggable loggable);
        public void Remove(ILoggable loggable);
        public void Notify(string message);
    }

    public class LogManager : ILogManageable
    {
        List<ILoggable> loggables = new List<ILoggable>();
        public void Add(ILoggable loggable)
        {
            loggables.Add(loggable);
        }

        public void Notify(string message)
        {
            loggables.ForEach(loggable =>
            {
                loggable.Log(message);
            });
        }

        public void Remove(ILoggable loggable)
        {
            loggables.Remove(loggable);
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            ILogManageable logManager = new LogManager();
            logManager.Add(new Email());
            logManager.Add(new File());
            logManager.Add(new UserConsole());
            //neka porikla od sistem
            logManager.Notify("Doslo je do errora");
        }
    }

}