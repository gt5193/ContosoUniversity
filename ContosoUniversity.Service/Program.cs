using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContosoUniversity.Api.Client;

namespace ContosoUniversity.Service
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new WeatherForecastClient("https://localhost:44339", new System.Net.Http.HttpClient());
            var weather = await client.GetAsync();
            foreach (var result in weather)
            {
                Console.WriteLine(result.TemperatureF + "F");
            }
            Console.ReadLine();
        }
        
    }
}
