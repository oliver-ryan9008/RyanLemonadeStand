using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    class Store
    {
        public static string lemonBuyPrompt;
        public static int lemonsPurchased;
        public static string sugarBuyPrompt;
        public static int sugarPurchased;
        public static string iceBuyPrompt;
        public static int icePurchased;
        public static string cupBuyPrompt;
        public static int cupsPurchased;
        static string checkLemonResponse;
        static string checkSugarResponse;
        static string checkIceResponse;
        static string checkCupsResponse;
        //public static int displayPurchasedCups;
        //public static int displayPurchasedLemons;
        //public static int displayPurchasedSugar;
        //public static int displayPurchasedIce;
        //public static int currentCups = 10;
        //public static int currentIce = 10;
        //public static int currentSugar = 10;
        //public static int currentLemons = 10;
        public static int totalCups;
        public static int totalLemons;
        public static int totalSugar;
        public static int totalIce;
        public static int BuyLemons()
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
                    BuyIce();
                }
                else
                {
                    BuyLemons();
                }
            }
            else
            {
                lemonsPurchased = int.Parse(lemonBuyPrompt);
                Console.WriteLine("You have purchased " + lemonsPurchased + " lemons.");
                Console.ReadKey();
                BuyIce();
            }
            return lemonsPurchased;
        }

        public static int BuyIce()
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
                    BuySugar();
                }
                else
                {
                    BuyIce();
                }
            }
            else
            {
                icePurchased = int.Parse(iceBuyPrompt);
                Console.WriteLine("You have purchased " + icePurchased + " cubes of ice.");
                Console.ReadKey();
                BuySugar();

            }
            return icePurchased;

        }

        public static int BuySugar()
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
                    BuyCups();
                }
                else
                {
                    BuySugar();
                }
            }
            else
            {
                sugarPurchased = int.Parse(sugarBuyPrompt);
                Console.WriteLine("You have purchased " + sugarPurchased + " servings of sugar.");
                Console.ReadKey();
                BuyCups();

            }
            return sugarPurchased;

        }

        public static int BuyCups()
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
                    
                }
                else
                {
                    BuyCups();
                }
            }
            else
            {
                cupsPurchased = int.Parse(cupBuyPrompt);
                Console.WriteLine("You have purchased " + cupsPurchased + " cups.");
                Console.ReadKey();
                UI.DisplayBackroomInventory();

            }
            return cupsPurchased;
        }
        public static int AddTotalCupsNumber(int cupsPurchased, int currentCups)
        {
            totalCups = cupsPurchased + currentCups;
            return totalCups;            
        }
        public static int AddTotalLemonsNumber(int lemonsPurchased, int currentLemons)
        {
            totalLemons = lemonsPurchased + currentLemons;
            return totalLemons;
            
        }
        public static int AddTotalSugarNumber(int sugarPurchased, int currentSugar)
        {
            totalSugar = sugarPurchased + currentSugar;
            return totalSugar;
        }
        public static int AddTotalIceNumber(int icePurchased, int currentIce)
        {
            totalIce = icePurchased + currentIce;
            return totalIce;
            
        }
        
        
        //string lemonBuyPrompt;
        //public int lemonsPurchased;
        //string sugarBuyPrompt;
        //public int sugarPurchased;
        //string iceBuyPrompt;
        //public int icePurchased;
        //string cupBuyPrompt;
        //public int cupsPurchased;
        //string checkLemonResponse;
        //string checkSugarResponse;
        //string checkIceResponse;
        //string checkCupsResponse;
        //public int displayCupsTotal;
        //public int displayLemonTotal;
        //public int displaySugarTotal;
        //public int displayIceTotal;


        //public int BuyLemons()
        //{
        //    Console.Clear();
        //    Console.WriteLine("How many lemons would you like to purchase?");
        //    lemonBuyPrompt = Console.ReadLine().ToLower();
        //    if (lemonBuyPrompt == "0")
        //    {
        //        Console.WriteLine("Are you sure you don't want any lemons?");
        //        checkLemonResponse = Console.ReadLine().ToLower();
        //        if (checkLemonResponse == "yes")
        //        {
        //            BuyIce();

        //        }
        //        else
        //        {
        //            BuyLemons();
        //        }
        //    }
        //    else
        //    {
        //        int lemonsPurchased = int.Parse(lemonBuyPrompt);
        //    }
        //    return lemonsPurchased;


        //}
        //public void BuyIce()
        //{
        //        Console.Clear();
        //        Console.WriteLine("How much ice would you like to buy?");
        //        iceBuyPrompt = Console.ReadLine().ToLower();
        //    if (lemonBuyPrompt == "0")
        //    {
        //        Console.WriteLine("Are you sure you don't want any ice?");
        //        checkIceResponse = Console.ReadLine().ToLower();
        //        if (checkIceResponse == "yes")
        //        {
        //            BuySugar();
        //        }
        //        else
        //        {
        //            BuyIce();
        //        }
        //    }
        //    else
        //    {
        //        icePurchased = int.Parse(Console.ReadLine());
        //        BuySugar();

        //    }
        //    Console.WriteLine("You have purchased " + icePurchased + " cubes of ice.");
        //}
        //public void BuySugar()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Would you like to buy some sugar? Enter yes or no.");
        //    sugarBuyPrompt = Console.ReadLine().ToLower();
        //    if (lemonBuyPrompt == "0")
        //    {
        //        Console.WriteLine("Are you sure you don't want any sugar?");
        //        checkSugarResponse = Console.ReadLine().ToLower();
        //        if (checkSugarResponse == "yes")
        //        {
        //            BuyCups();
        //        }
        //        else
        //        {
        //            BuySugar();
        //        }
        //    }
        //    else
        //    {
        //        sugarPurchased = int.Parse(Console.ReadLine());
        //        BuyCups();

        //    }
        //    Console.WriteLine("You have purchased " + sugarPurchased + " servings of sugar.");
        //}


        //public void BuyCups()
        //{
        //    Console.Clear();
        //    Console.WriteLine("How many cups would you like to buy?");
        //    cupBuyPrompt = Console.ReadLine().ToLower();
        //    if (cupBuyPrompt == "0")
        //    {
        //        Console.WriteLine("Are you sure you don't want any cups?");
        //        checkCupsResponse = Console.ReadLine().ToLower();
        //        if (checkCupsResponse == "yes")
        //        {
        //            UI.DisplayInventory();
        //        }
        //        else
        //        {
        //            BuyCups();
        //        }
        //    }
        //    else
        //    {
        //        cupsPurchased = int.Parse(Console.ReadLine());
        //        UI.DisplayInventory();
        //    }

        //    Console.WriteLine("You have purchased " + cupsPurchased + " cups.");

        //}

        //    public void DisplayInventoryTotals()
        //    {
        //        int displayCupsTotal = cupsPurchased + player.currentCups;
        //    }
    }
}
