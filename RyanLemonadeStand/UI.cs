using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public static class UI
    {
        //public static string lemonBuyPrompt;
        
        //public static string sugarBuyPrompt;
        
        //public static string iceBuyPrompt;
        
        //public static string cupBuyPrompt;
        public static int cupsPurchased;
        public static int lemonsPurchased;
        public static int sugarPurchased;
        public static int icePurchased;
        //static string checkLemonResponse;
        //static string checkSugarResponse;
        //static string checkIceResponse;
        //static string checkCupsResponse;
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


        public static void GetUserStoreInputs()
        {

        }

        public static void UserAddToInventory()
        {
            DisplayBackroomInventory();            
            Console.WriteLine("Would you like to buy some more items to add to your inventory?");
            string userAddToInventoryPromp = Console.ReadLine().ToString();
            if (userAddToInventoryPromp == "yes")
            {
                Store.BuyLemons();
            }
            else
            {
                Console.Clear();
                
            }
        }

        public static void DisplayBackroomInventory()
        {
            Console.WriteLine("You have " + Player.currentLemons + " lemons on hand.");
            Console.WriteLine("You have " + Player.currentSugar + " servings of sugar on hand.");
            Console.WriteLine("You have " + Player.currentIce + " cubes of ice on hand.");
            Console.WriteLine("You have " + Player.currentCups + " cups on hand.");
        }

        public static void DisplayRestockedInventory(int totalSugar, int totalLemons, int totalIce, int totalCups)
        {
            
            Console.WriteLine("After all purchases you have " + Store.totalLemons + " lemons in your inventory.");
            Console.WriteLine("After all purchases you have " + Store.totalSugar + " servings of sugar in your inventory.");
            Console.WriteLine("After all purchases you have " + Store.totalIce + " cubes of ice in your inventory.");
            Console.WriteLine("After all purchases you have " + Store.totalCups + " cups in your inventory.");
        }



        
            

            

        
        
        


        

            

        
    }
}

