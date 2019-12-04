using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public class GetWeather
    {
        public static async Task<string> GetTempAsync()
        {
            HttpClient httpClient = new HttpClient();
            String kit = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=60106437d06f8b03762ea496f3bd3643");

            TheWeather theweather  = JsonConvert.DeserializeObject<TheWeather>(kit);
            string returnString = string.Empty;

            for (int index = 0; index < theweather.weather.Count; index++)
            {
                returnString = theweather.weather[index].description;

            }

       
            return returnString;


        }
       



    }
}
