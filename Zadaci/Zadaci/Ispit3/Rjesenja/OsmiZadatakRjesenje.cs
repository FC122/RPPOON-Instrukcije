/*Za primjer da izlistanjem koda odredite obrazac o kojem je rjec i njegovu skupinu.
Dopunite kod implementacijom koja nedostaje te napisite klijentski kod za ovaj primjer*/
namespace OsmiZadatakTest3
{
    // Detector interface
    public interface IDetector
    {
        void Notify();
        void StartWatching(IWatcher watcher);
        void StopWatching(IWatcher watcher);
    }

    public class LogDatabase
    {
        private static LogDatabase instance;

        private LogDatabase() { }

        public static LogDatabase Create()
        {
            if (instance == null)
            {
                instance = new LogDatabase();
            }
            return instance;
        }

        public void Insert(DateTime timestamp, double value)
        {
            Console.WriteLine($"Logged: {timestamp} - Value: {value}");
        }
    }

    // Watcher interface
    public interface IWatcher
    {
        void OnDetection(double value);
    }

    // Concrete class EarthquakeDetector implementing IDetector
    public class EarthquakeDetector : IDetector
    {
        private double sensorValue = 0;
        private List<IWatcher> watchers = new List<IWatcher>();

        public void MeasurePeriodically(int period)
        {
            // Triggers every period milliseconds
            double measured = Measure();
            bool shouldNotify = measured > sensorValue;
            sensorValue = measured;
            if (shouldNotify)
            {
                Notify();
            }
        }

        private double Measure()
        {
            // Measurement logic
            return 0; // Placeholder for actual measurement
        }

        public void StartWatching(IWatcher watcher)
        {
            watchers.Add(watcher);
        }

        public void StopWatching(IWatcher watcher)
        {
            watchers.Remove(watcher);
        }

        public void Notify()
        {
            foreach (IWatcher watcher in watchers)
            {
                watcher.OnDetection(sensorValue);
            }
        }
    }

    // Concrete class Logger implementing IWatcher
    public class Logger : IWatcher
    {
        private LogDatabase logDatabase;

        public Logger()
        {
            logDatabase = LogDatabase.Create();
        }

        public void OnDetection(double value)
        {
            logDatabase.Insert(DateTime.Now, value);
        }
    }

    public static class ClientCode
    {
        static void Run()
        {
            EarthquakeDetector detector = new EarthquakeDetector();
            Logger logger = new Logger();

            detector.StartWatching(logger);
            detector.MeasurePeriodically(1000); // Simulate periodic measurement

            // To stop watching:
            // detector.StopWatching(logger);
        }
    }
}