using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    class Store
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
        public static int totalCups;
        public static int totalLemons;
        public static int totalSugar;
        public static int totalIce;
        public int BuyLemons()
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
                    return BuyLemons();                    
                }
            }
            else
            {
                lemonsPurchased = int.Parse(lemonBuyPrompt);
                
                Console.WriteLine("You have purchased " + lemonsPurchased + " lemons.");
                Console.ReadKey();
                return lemonsPurchased;

            }
            
        }

        public int BuyIce()
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
                    return BuyIce();
                }
            }
            else
            {
                icePurchased = int.Parse(iceBuyPrompt);
                
                Console.WriteLine("You have purchased " + icePurchased + " cubes of ice.");
                Console.ReadKey();
                return icePurchased;

            }
            

        }

        public int BuySugar()
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
                    return BuySugar();
                }
            }
            else
            {
                sugarPurchased = int.Parse(sugarBuyPrompt);
                
                Console.WriteLine("You have purchased " + sugarPurchased + " servings of sugar.");
                Console.ReadKey();
                return sugarPurchased;

            }
            

        }

        public int BuyCups()
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
                    return BuyCups();
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
        public int AddTotalLemonsNumber()
        {
            totalLemons = lemonsPurchased + UI.currentLemons;
            return totalLemons;

        }       
        public int AddTotalSugarNumber()
        {
            totalSugar = sugarPurchased + UI.currentSugar;
            return totalSugar;
        }
        public int AddTotalIceNumber()
        {
            totalIce = icePurchased + UI.currentIce;
            return totalIce;
            
        }
        public int AddTotalCupsNumber()
        {
            totalCups = cupsPurchased + UI.currentCups;
            return totalCups;
        }
    }
}
