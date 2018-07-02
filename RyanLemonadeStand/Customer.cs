using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    class Customer
    {
        Random random;
        public int buyChance;
        public bool customerWhoApproaches;
        public bool customerWhoBuys;
        public int numberOfApproachingCustomers;
        public int possibleCustomer;
        public int combinedWeather;
        public List<int> customerApproaching = new List<int>();
        public List<int> potentialCustomers = new List<int>();
        public int min = 0;
        public int max = 0;

        public Customer()
        {
            //this.random = randomNumber;
        }
        public int CustomerPurchaseRate(int min, int max, Day day)
        {
            foreach (int customerWhoBuys in potentialCustomers)
            {
                buyChance = random.Next(0, 100);
                if (day.combinedWeather == 10)
                {
                    if (buyChance < 90)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
                else if (day.combinedWeather == 9)
                {
                    if (buyChance < 80)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
                else if (day.combinedWeather == 8)
                {
                    if (buyChance < 70)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
                else if (day.combinedWeather == 7)
                {
                    if (buyChance < 60)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
                else if (day.combinedWeather == 6)
                {
                    if (buyChance < 50)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
                else if (day.combinedWeather == 5)
                {
                    if (buyChance < 40)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
                else if (day.combinedWeather == 4)
                {
                    if (buyChance < 30)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
                else if (day.combinedWeather == 3)
                {
                    if (buyChance < 20)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
                else if (day.combinedWeather == 2)
                {
                    if (buyChance < 15)
                    {
                        customerWhoApproaches = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        customerWhoApproaches = false;
                    }
                }
            }
            numberOfApproachingCustomers = customerApproaching.Count;
            return numberOfApproachingCustomers;
        }
        public void GenerateCustomers(Random random, Day day, int min, int max)
        {
            

            int numberOfCustomers = random.Next(min, max);


            if (combinedWeather == 2)
            {
                possibleCustomer = random.Next(50, 120);
            }
            else if (combinedWeather == 3)
            {
                possibleCustomer = random.Next(121, 125);
            }
            else if (combinedWeather == 4)
            {
                possibleCustomer = random.Next(126, 200);
            }
            else if (combinedWeather == 5)
            {
                possibleCustomer = random.Next(201, 300);
            }
            else if (combinedWeather == 6)
            {
                possibleCustomer = random.Next(301, 500);
            }
            else if (combinedWeather == 7)
            {
                possibleCustomer = random.Next(501, 700);
            }
            else if (combinedWeather == 8)
            {
                possibleCustomer = random.Next(701, 900);
            }
            else if (combinedWeather == 9)
            {
                possibleCustomer = random.Next(901, 1250);
            }
            else if (combinedWeather == 10)
            {
                possibleCustomer = random.Next(1251, 2000);

            }
            for (int customers = 1; customers <= numberOfCustomers; customers++)
            {
                potentialCustomers.Add(1);
            }
        }
    }
}
