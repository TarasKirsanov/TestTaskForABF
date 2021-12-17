using Newtonsoft.Json;
using System;
using TestTaskForABF.Helpers;

namespace TestTaskForABF.Models
{
    public class DailyWeatherForecast
    {
        [JsonProperty("dt")]
        public long DateTime { get; set; }

        [JsonProperty("temp")]
        public DailyTemperature Temperature { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }

        public override string ToString() => $"Date: {DateTimeHelper.ConvertUnixTimeToDateTime(DateTime)},{Environment.NewLine}" +
                                             $"Temperature: {Temperature},{Environment.NewLine}" +
                                             $"Pressure: {Pressure} P,{Environment.NewLine}" +
                                             $"Humidity: {Humidity} oz. {Environment.NewLine}";
    }
}