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

        public Weather()
        {
            weatherconditions = new List<string>
            {
                "Sunny","Cloudy", "Rainy",
            };
            condition = GenerateWeather();
            temperature = GenerateTemperature();
        }
        public string GenerateForecast()
        {
            
            Random random = new Random();
            return weatherconditions[random.Next(weatherconditions.Count)];
        }

        public string GenerateWeather()
        {
            Random random = new Random();
            int index = random.Next(weatherconditions.Count);
            condition = weatherconditions[index];
            return condition;

        }
        private int GenerateTemperature()
        {
            Random random = new Random();
            int temperature = random.Next(50, 101);
            return temperature;
        }
        
        

       





    }
}
