using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    class Store
    {
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
