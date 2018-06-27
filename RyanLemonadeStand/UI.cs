using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public static class UI
    {
        public static int lemonBuyPrompt;
        public static int lemonsPurchased;
        public static int sugarBuyPrompt;
        public static int sugarPurchased;
        public static int iceBuyPrompt;
        public static int icePurchased;
        public static int cupBuyPrompt;
        public static int cupsPurchased;
        static string checkLemonResponse;
        static string checkSugarResponse;
        static string checkIceResponse;
        static string checkCupsResponse;
        public static int displayPurchasedCups;
        public static int displayPurchasedLemons;
        public static int displayPurchasedSugar;
        public static int displayPurchasedIce;
        public static int currentCups = 10;
        public static int currentIce = 10;
        public static int currentSugar = 10;
        public static int currentLemons = 10;
        public static void DisplayInventory()
        {
            Console.Clear();
            Console.WriteLine("This is where inventory will show once I get it working.");
            Console.ReadKey();
        }

        public static void GetUserStoreInputs()
        {

        }

        public static int DisplayTotalCupsNumber()
        {
            int totalCups = cupsPurchased + currentCups;
            return totalCups;
        }
        public static int DisplayTotalLemonsNumber()
        {
            int totalLemons = lemonsPurchased + currentLemons;
            return totalLemons;
        }
        public static int DisplayTotalSugarNumber()
        {
            int totalSugar = sugarPurchased + currentSugar;
            return totalSugar;
        }
        public static int DisplayTotalIceNumber()
        {
            int totalIce = icePurchased + currentIce;
            return totalIce;
        }

        public static int BuyLemons()
        {
            Console.Clear();
            Console.WriteLine("How many lemons would you like to buy?");
            lemonBuyPrompt = int.Parse(Console.ReadLine());
            if (lemonBuyPrompt == 0)
            {
                Console.WriteLine("Are you sure you don't want any cups?");
                checkLemonResponse = Console.ReadLine().ToLower();
                if (checkLemonResponse == "yes")
                {
                    BuyIce();
                }
                else
                {
                    BuyLemons();
                }
            }
            else
            {
                lemonsPurchased = lemonBuyPrompt;
                //UI.DisplayInventory();
            }
            return lemonsPurchased;

            

        }
        public static void BuyIce()
        {
            Console.Clear();
            Console.WriteLine("How much ice would you like to buy?");
            iceBuyPrompt = int.Parse(Console.ReadLine());
            if (lemonBuyPrompt == 0)
            {
                Console.WriteLine("Are you sure you don't want any ice?");
                checkIceResponse = Console.ReadLine().ToLower();
                if (checkIceResponse == "yes")
                {
                    BuySugar();
                }
                else
                {
                    BuyIce();
                }
            }
            else
            {
                icePurchased = int.Parse(Console.ReadLine());
                BuySugar();

            }
            Console.WriteLine("You have purchased " + icePurchased + " cubes of ice.");
        }
        public static void BuySugar()
        {
            Console.Clear();
            Console.WriteLine("Would you like to buy some sugar? Enter yes or no.");
            sugarBuyPrompt = int.Parse(Console.ReadLine());
            if (lemonBuyPrompt == 0)
            {
                Console.WriteLine("Are you sure you don't want any sugar?");
                checkSugarResponse = Console.ReadLine().ToLower();
                if (checkSugarResponse == "yes")
                {
                    BuyCups();
                }
                else
                {
                    BuySugar();
                }
            }
            else
            {
                sugarPurchased = int.Parse(Console.ReadLine());
                BuyCups();

            }
            Console.WriteLine("You have purchased " + sugarPurchased + " servings of sugar.");
        }


        public static void BuyCups()
        {
            Console.Clear();
            Console.WriteLine("How many cups would you like to buy?");
            cupBuyPrompt = int.Parse(Console.ReadLine());
            if (cupBuyPrompt == 0)
            {
                Console.WriteLine("Are you sure you don't want any cups?");
                checkCupsResponse = Console.ReadLine().ToLower();
                if (checkCupsResponse == "yes")
                {
                    UI.DisplayInventory();
                }
                else
                {
                    BuyCups();
                }
            }
            else
            {
                cupsPurchased = int.Parse(Console.ReadLine());
                UI.DisplayInventory();
            }

            Console.WriteLine("You have purchased " + cupsPurchased + " cups.");

        }
    }
}

