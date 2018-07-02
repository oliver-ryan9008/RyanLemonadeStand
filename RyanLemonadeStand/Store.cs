using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public class Store
    {

        public string lemonBuyPrompt;
        public int lemonsPurchased;
        public string sugarBuyPrompt;
        public int sugarPurchased;
        public string iceBuyPrompt;
        public int icePurchased;
        public string cupBuyPrompt;
        public int cupsPurchased;
        public string checkLemonResponse;
        public string checkSugarResponse;
        public string checkIceResponse;
        public string checkCupsResponse;
        public int totalCups;
        public int totalLemons;
        public int totalSugar;
        public int totalIce;
        public double moneySpent;
        public double lemonadeCupPrice;
        public int BuyLemons(Player player)
        {
            Console.Clear();
            Console.WriteLine("How many lemons would you like to buy?");
            lemonBuyPrompt = Console.ReadLine();
            if (lemonBuyPrompt == "0")
            {

                Console.WriteLine("Are you sure you don't want any lemons?");
                checkLemonResponse = Console.ReadLine().ToLower();
                if (checkLemonResponse == "yes")
                {
                    return lemonsPurchased;
                }
                else
                {
                    return BuyLemons(player);                    
                }
            }
            else
            {
                lemonsPurchased = int.Parse(lemonBuyPrompt);
                
                Console.WriteLine("You have purchased " + lemonsPurchased + " lemons.");
                Console.ReadKey();
                player.lemonInventory--;
                return lemonsPurchased;

            }
            
        }

        public int BuyIce(Player player)
        {
            Console.Clear();
            Console.WriteLine("How much ice would you like to buy?");
            iceBuyPrompt = Console.ReadLine();
            if (iceBuyPrompt == "0")
            {
                Console.WriteLine("Are you sure you don't want any ice?");
                checkIceResponse = Console.ReadLine().ToLower();
                if (checkIceResponse == "yes")
                {
                    return icePurchased;
                }
                else
                {
                    return BuyIce(player);
                }
            }
            else
            {
                icePurchased = int.Parse(iceBuyPrompt);
                
                Console.WriteLine("You have purchased " + icePurchased + " cubes of ice.");
                Console.ReadKey();
                player.iceInventory--;
                return icePurchased;

            }
            

        }

        public int BuySugar(Player player)
        {
            Console.Clear();
            Console.WriteLine("How many servings of sugar would you like to buy?");
            sugarBuyPrompt = Console.ReadLine();
            if (sugarBuyPrompt == "0")
            {
                Console.WriteLine("Are you sure you don't want any sugar?");
                checkSugarResponse = Console.ReadLine().ToLower();
                if (checkSugarResponse == "yes")
                {
                    return sugarPurchased;
                }
                else
                {
                    return BuySugar(player);
                }
            }
            else
            {
                sugarPurchased = int.Parse(sugarBuyPrompt);
                
                Console.WriteLine("You have purchased " + sugarPurchased + " servings of sugar.");
                Console.ReadKey();
                player.sugarInventory--;
                return sugarPurchased;

            }
            

        }

        public int BuyCups(Player player)
        {
            Console.Clear();
            Console.WriteLine("How many cups would you like to buy?");
            cupBuyPrompt = Console.ReadLine();
            if (cupBuyPrompt == "0")
            {
                Console.WriteLine("Are you sure you don't want any cups?");
                checkCupsResponse = Console.ReadLine().ToLower();
                if (checkCupsResponse == "yes")
                {
                    return cupsPurchased;
                }
                else
                {
                    return BuyCups(player);
                }
            }
            else
            {
                cupsPurchased = int.Parse(cupBuyPrompt);
                
                Console.WriteLine("You have purchased " + cupsPurchased + " cups.");
                Console.ReadKey();
                
                return cupsPurchased;
                

            }
            
        }
        public void AddTotalLemonsNumber(Player player)
        {
            totalLemons = lemonsPurchased + player.currentLemons;
            //return totalLemons;

        }       
        public void AddTotalSugarNumber(Player player)
        {
            totalSugar = sugarPurchased + player.currentSugar;
            //return totalSugar;
        }
        public void AddTotalIceNumber(Player player)
        {
            totalIce = icePurchased + player.currentIce;
            //return totalIce;
            
        }
        public void AddTotalCupsNumber(Player player)
        {
            totalCups = cupsPurchased + player.currentCups;
            //return totalCups;
        }
    }
}
