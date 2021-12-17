using Newtonsoft.Json;
using System;

namespace TestTaskForABF.Models
{
    public class DailyTemperature
    {
        public double Day { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Night { get; set; }

        [JsonProperty("eve")]
        public double Evening { get; set; }

        [JsonProperty("morn")]
        public double Morning { get; set; }

        public override string ToString() => $"Day: {Day} C,{Environment.NewLine}" +
                                             $"Min: {Min} C,{Environment.NewLine}" +
                                             $"Max: {Max} C,{Environment.NewLine}" +
                                             $"Night: {Night} C,{Environment.NewLine}" +
                                             $"Evening: {Evening} C,{Environment.NewLine}" +
                                             $"Morning: {Morning} C";
    }
}