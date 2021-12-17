using System;
using TestTaskForABF.Managers;

namespace TestTaskForABF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherForecastManager = new WeatherForecastManager(); 
            Console.WriteLine(weatherForecastManager.GetWeekWeatherForecast(35.16889, 33.35917, "metric")); // These are the coordinates of the capital of Cyprus - Nicosia
            Console.ReadKey();
        }
    }
}