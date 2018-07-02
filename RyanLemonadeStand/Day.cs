using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public class Day
    {
        //public int buyRate;
        public int temperatureReading;
        public int conditions;
        public int min;
        public int max;
        //public static int random = random;
        public int combinedWeather;
        public int randomConditions;
        public int randomTemperature;
        public int randomWeather;
        
        List<Customer> customers;
        //public static int weather;

        public Day()
        {

        }









            public int TemperatureGenerator()
            {
            Random randomTemparatureGenerator = new Random();
            randomTemperature = randomTemparatureGenerator.Next(50, 100);
            if (randomTemperature >= 50 && randomTemperature <= 60)
            {
            temperatureReading = 1;
            string displayTemperature = randomTemperature.ToString();
            }
            else if (randomTemperature >= 61 && randomTemperature <= 70)
            {
            temperatureReading = 2;
            string displayTemperature = randomTemperature.ToString();
            }
            else if (randomTemperature >= 71 && randomTemperature <= 80)
            {
                temperatureReading = 3;
                string displayTemperature = randomTemperature.ToString();
            }
            else if (randomTemperature >= 81 && randomTemperature <= 90)
            {
                temperatureReading = 4;
                string displayTemperature = randomTemperature.ToString();
            }
            else if (randomTemperature >= 91 && randomTemperature <= 100)
            {
                temperatureReading = 5;
                string displayTemperature = randomTemperature.ToString();
            }
            return temperatureReading;
        }
            public int ConditionsGenerator()
            {
            Random randomWeatherConditionsGenerator = new Random();
            randomConditions = randomWeatherConditionsGenerator.Next(1, 5);
            if (randomConditions == 1)
            {
                conditions = 1;
            }
            else if (randomConditions == 2)
            {
                conditions = 2;
            }
            else if (randomConditions == 3)
            {
                conditions = 3;
            }
            else if (randomConditions == 4)
            {
                conditions = 4;
            }
            else if (randomConditions == 5)
            {
                conditions = 5;
            }
            return conditions;
        }

        public int Weather()
        {
        randomWeather = conditions + temperatureReading;
        if (randomWeather == 2)
        {
            combinedWeather = 2;
        }
        else if (randomWeather == 3)
        {
            combinedWeather = 3;
        }
        else if (randomWeather == 4)
        {
            combinedWeather = 4;
        }
        else if (randomWeather == 5)
        {
            combinedWeather = 5;
        }
        else if (randomWeather == 6)
        {
            combinedWeather = 6;
        }
        else if (randomWeather == 7)
        {
            combinedWeather = 7;
        }
        else if (randomWeather == 8)
        {
            combinedWeather = 8;
        }
        else if (randomWeather == 9)
        {
            combinedWeather = 9;
        }
        else if (randomWeather == 10)
        {
            combinedWeather = 10;
        }
        return combinedWeather;
        }
    }
}