
// interface ILiveWeatherForecast
// {
//     public void Register(IWeatherProcessor processor);
//     public void Unregister(IWeatherProcessor processor);
//     public void Notify();
// }
// interface IWeatherProcessor { public void OnWeatherChanged(Weather weather); }
// class WeatherForecastProvider : ILiveWeatherForecast
// {
//     private DateTime lastUpdate = DateTime.Now;
//     private Weather currentWeather = WeatherService.GetWeatherForecast();
//     private List<IWeatherProcessor> processors = new List<IWeatherProcessor>();
//     public void Register(IWeatherProcessor processor) { processors.Add(processor); }
//     public void PeriodicUpdate()
//     {
//         if (DateTime.Now >= lastUpdate.AddHours(1))
//         {
//             currentWeather = WeatherService.GetWeatherForecast();
//             Notify();
//         }
//     }
// }
// class WeatherStatistics : IWeatherProcessor
// {
//     public void OnWeatherChanged(Weather weather)
//     {
//         /*Track weather statistics. Ignore impl. */
//     }
// }
// class WeatherDisplay : IWeatherProcessor
// {
//     public void OnWeatherChanged(Weather weather)
//     {
//         /*1.Display weather data. Ignore impl.. */
//     }
// }