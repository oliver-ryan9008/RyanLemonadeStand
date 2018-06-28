using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    class Customer
    {
        public int buyChance;
        public int CustomerPurchaseRate(Random random, Day day, int min, int max)
        {
            buyChance = random.Next(min, max);
            if (day.combinedWeather == 2)
            {
                int buyChance = random.Next(50, 120);
            }
            else if (day.combinedWeather == 3)
            {
                int buyChance = random.Next(121, 125);
            }
            else if (day.combinedWeather == 4)
            {
                int buyChance = random.Next(126, 200);
            }
            else if (day.combinedWeather == 5)
            {
                int buyChance = random.Next(201, 300);
            }
            else if (day.combinedWeather == 6)
            {
                int buyChance = random.Next(301, 500);
            }
            else if (day.combinedWeather == 7)
            {
                int buyChance = random.Next(501, 700);
            }
            else if (day.combinedWeather == 8)
            {
                int buyChance = random.Next(701, 900);
            }
            else if (day.combinedWeather == 9)
            {
                int buyChance = random.Next(901, 1250);
            }
            else if (day.combinedWeather == 10)
            {
                int buyChance = random.Next(1251, 2000);
            }
            return buyChance;
        }
        public void GenerateCustomers(Random random)
        {
            int min = 75;
            int max = 125;

            int numberOfCustomers = random.Next(min, max);
            for (int i = 0; i < numberOfCustomers; i++)
            {

                customers.Add(new Customer(random));
            }
        }
    }
}
