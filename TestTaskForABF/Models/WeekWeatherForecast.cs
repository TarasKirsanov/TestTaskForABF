using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TestTaskForABF.Models
{
    public class WeekWeatherForecast
    {
        [JsonProperty("daily")]
        public List<DailyWeatherForecast> DailyWeatherForecasts { get; set; }
        public string TimeZone { get; set; }

        public override string ToString() => $"Time Zone: {TimeZone},{Environment.NewLine}" +
                                             $"Wether forecast for the week:{Environment.NewLine}" +
                                             $"{string.Join(Environment.NewLine, DailyWeatherForecasts)}";
    }
}