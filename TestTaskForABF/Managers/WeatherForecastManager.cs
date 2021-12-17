using System.IO;
using System.Net;
using TestTaskForABF.Models;
using Newtonsoft.Json;

namespace TestTaskForABF.Managers
{
    public class WeatherForecastManager
    {
        public WeekWeatherForecast GetWeekWeatherForecast(double latitude, double longitude, string units = "standard")
        {
            string url = $"https://api.openweathermap.org/data/2.5/onecall?lat={latitude}&lon={longitude}&units={units}&appid={ProgramConstants.ApiKey}";

            var request = (HttpWebRequest) WebRequest.Create(url);

            var httpWebResponse = (HttpWebResponse) request.GetResponse();

            if (httpWebResponse.StatusCode != HttpStatusCode.OK)
                throw new System.InvalidOperationException($"Status of response {httpWebResponse.StatusCode}");

            using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                var response = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<WeekWeatherForecast>(response);
            }
        }
    }
}
