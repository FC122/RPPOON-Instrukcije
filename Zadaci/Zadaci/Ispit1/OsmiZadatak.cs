namespace OsmiZadatak
{
    /*Za primjer da izlistanjem koda odredite obrazac o kojem je rjec i njegovu skupinu.
    Dopunite kod implementacijom koja nedostaje te napisite klijentski kod za ovaj primjer*/
    //     interface ILiveWeatherForecast
    //     {
    //         void Register(IWeatherProcessor processor);
    //         void Unregister(IWeatherProcessor processor);
    //         void Notify();
    //     }

    //     interface IWeatherProcessor
    //     {
    //         void OnWeatherChanged(Weather weather);
    //     }

    //     class WeatherForecastProvider : ILiveWeatherForecast
    //     {
    //         private DateTime lastUpdate = DateTime.Now;
    //         private Weather currentWeather = 
    //WeatherService.GetWeatherForecast();
    //         private List<IWeatherProcessor> processors = 
    //new List<IWeatherProcessor>();

    //         public void Register(IWeatherProcessor processor)
    //         {
    //             processors.Add(processor);
    //         }

    //         public void PeriodicUpdate()
    //         {
    //             if (DateTime.Now >= lastUpdate.AddHours(1))
    //             {
    //                 currentWeather = WeatherService.GetWeatherForecast();
    //                 Notify();
    //             }
    //         }
    //     }

    //     class WeatherStatistics : IWeatherProcessor
    //     {
    //         public void OnWeatherChanged(Weather weather)
    //         {
    //             // Track weather statistics. Ignore implementation.
    //         }
    //     }

    //     class WeatherDisplay : IWeatherProcessor
    //     {
    //         public void OnWeatherChanged(Weather weather)
    //         {
    //             // Display weather data. Ignore implementation.
    //         }
    //     }
    public static class ClientCode
    {
        public static void Run()
        {

        }
    }
}