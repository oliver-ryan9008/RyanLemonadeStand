using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public class Customer
    {
        public int buyChance;
        public bool buyer;
        public int totalDaySales;
        //public int customerWhoBuys;
        public int totalBuyers;
        public List<int> buyingCustomer = new List<int>();
        public List<int> potentialCustomers = new List<int>();
        public int min = 0;
        public int max = 0;

        public Customer()
        {
            //this.random = randomNumber;
        }

        public int CustomersWhoPurchased(Player player)
        {
            for(int i = 0; i <= totalBuyers; i++)
                if(player.enoughInventory == true)
                {
                    player.totalLemonadeCreated--;
                    totalDaySales++;
                }
                else{
                    Console.WriteLine("You did not sell any lemonade today!");
                }
            return totalDaySales;
        }
        public int CustomerPurchaseRate(int min, int max, Day day)
        {
            foreach (int customerWhoBuys in potentialCustomers)
            {
                Random random = new Random();
                buyChance = random.Next(0, 100);
                if (day.combinedWeather == 10)
                {
                    if (buyChance < 90)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
                else if (day.combinedWeather == 9)
                {
                    if (buyChance < 80)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
                else if (day.combinedWeather == 8)
                {
                    if (buyChance < 70)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
                else if (day.combinedWeather == 7)
                {
                    if (buyChance < 60)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
                else if (day.combinedWeather == 6)
                {
                    if (buyChance < 50)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
                else if (day.combinedWeather == 5)
                {
                    if (buyChance < 40)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
                else if (day.combinedWeather == 4)
                {
                    if (buyChance < 30)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
                else if (day.combinedWeather == 3)
                {
                    if (buyChance < 20)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
                else if (day.combinedWeather == 2)
                {
                    if (buyChance < 15)
                    {
                        buyer = true;
                        buyingCustomer.Add(1);
                    }
                    else
                    {
                        buyer = false;
                    }
                }
            }
            totalBuyers = buyingCustomer.Count;
            return totalBuyers;
        }
        public void GenerateCustomers(Day day, int min, int max)
        {
            this.min = 0;
            this.max = 2000;
            Random random = new Random();
            int approachingCustomer = random.Next(min, max);


            if (day.combinedWeather == 2)
            {
                approachingCustomer = random.Next(50, 120);
            }
            else if (day.combinedWeather == 3)
            {
                approachingCustomer = random.Next(121, 125);
            }
            else if (day.combinedWeather == 4)
            {
                approachingCustomer = random.Next(126, 200);
            }
            else if (day.combinedWeather == 5)
            {
                approachingCustomer = random.Next(201, 300);
            }
            else if (day.combinedWeather == 6)
            {
                approachingCustomer = random.Next(301, 500);
            }
            else if (day.combinedWeather == 7)
            {
                approachingCustomer = random.Next(501, 700);
            }
            else if (day.combinedWeather == 8)
            {
                approachingCustomer = random.Next(701, 900);
            }
            else if (day.combinedWeather == 9)
            {
                approachingCustomer = random.Next(901, 1250);
            }
            else if (day.combinedWeather == 10)
            {
                approachingCustomer = random.Next(1251, 2000);
            }
            for (int totalCustomers = 1; totalCustomers <= approachingCustomer; totalCustomers++)
            {
                potentialCustomers.Add(1);
            }
        }
    }
}
