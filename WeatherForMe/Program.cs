using System;
using System.Threading.Tasks;
using WeatherLibrary;

namespace WeatherForMe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string weatherString = await GetWeather.GetTempAsync();
            Console.WriteLine(weatherString);



            //Console.WriteLine("Hello World!");
        }
    }
}
