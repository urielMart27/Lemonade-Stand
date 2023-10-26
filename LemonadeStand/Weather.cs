using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
       public string condition;
       public int temperature;
       public List<string> weatherconditions;
       string predictedForecast;

        public Weather()
        {
            weatherconditions = new List<string>
            {
                "Sunny","Cloudy", "Rainy",
            };
            condition = GenerateWeather();
            predictedForecast = GenerateForecast();
            temperature = GenerateTemperature();
        }
        public string GenerateForecast()
        {
            
            Random random = new Random();
            int index = random.Next(weatherconditions.Count);
            predictedForecast =weatherconditions[index];
            return predictedForecast;
        }

        public string GenerateWeather()
        {
            Random random = new Random();
            int index = random.Next(weatherconditions.Count);
            return weatherconditions[index];

        }
        private int GenerateTemperature()
        {
            Random random = new Random();
            int temperature = random.Next(50, 101);
            return temperature;
        }
        
        

       





    }
}
