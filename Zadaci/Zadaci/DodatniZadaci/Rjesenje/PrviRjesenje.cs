/*
Za primjer dan izlistanjem kôda odredite obrazac o 
kojem je riječ i njegovu skupinu. 
Dopunite kôd implementacijom koja nedostaje te 
napišite klijentski kôd za ovaj primjer.
*/
/*Promatrac*/
namespace Prvi
{

    public class WeatherService
    {
        public static Weather GetWeatherForecast()
        {
            Weather weather = new Weather();
            return weather;
        }
    }
    public class Weather
    {
    }

    interface ILiveWeatherForecast
    {
        public void Register(IWeatherProcessor processor);
        public void Unregister(IWeatherProcessor processor);
        public void Notify();
    }
    interface IWeatherProcessor { public void OnWeatherChanged(Weather weather); }
    class WeatherForecastProvider : ILiveWeatherForecast
    {
        private DateTime lastUpdate = DateTime.Now;
        private Weather currentWeather = WeatherService.GetWeatherForecast();
        private List<IWeatherProcessor> processors = new List<IWeatherProcessor>();
        public void Register(IWeatherProcessor processor) { processors.Add(processor); }
        public void PeriodicUpdate()
        {
            if (DateTime.Now >= lastUpdate.AddHours(1))
            {
                currentWeather = WeatherService.GetWeatherForecast();
                Notify();
            }
        }

        public void Notify()
        {
            foreach (var processor in processors)
            {
                processor.OnWeatherChanged(currentWeather);
            }
        }

        public void Unregister(IWeatherProcessor processor)
        {
            processors.Remove(processor);
        }
    }
    class WeatherStatistics : IWeatherProcessor
    {
        public void OnWeatherChanged(Weather weather)
        {
            /*Track weather statistics. Ignore impl. */
        }
    }
    class WeatherDisplay : IWeatherProcessor
    {
        public void OnWeatherChanged(Weather weather)
        {
            /*1.Display weather data. Ignore impl.. */
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeatherForecastProvider forecastProvider = new WeatherForecastProvider();
            WeatherStatistics statisticsProcessor = new WeatherStatistics();
            forecastProvider.Register(statisticsProcessor);
            WeatherDisplay displayProcessor = new WeatherDisplay();
            forecastProvider.Register(displayProcessor);
            while (true)
            {
                forecastProvider.PeriodicUpdate();

                Thread.Sleep(1000 * 60 * 60);
            }
        }
    }

}