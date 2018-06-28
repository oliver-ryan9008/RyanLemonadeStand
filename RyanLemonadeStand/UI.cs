using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public static class UI
    {
        public static int currentCups = Player.currentCups;
        public static int currentIce = Player.currentIce;
        public static int currentSugar = Player.currentSugar;
        public static int currentLemons = Player.currentLemons;


        public static void GetUserStoreInputs()
        {

        }

        public static void UserAddToInventory()
        {
                     
            Console.WriteLine("Would you like to buy some more items to add to your inventory?");
            string userAddToInventoryPromp = Console.ReadLine().ToString();
            if (userAddToInventoryPromp == "yes")
            {
                
            }
            else
            {
                Console.Clear();
                
            }
        }

        public static void DisplayBackroomInventory()
        {
            Console.WriteLine("You have " + currentLemons + " lemons on hand.");
            Console.WriteLine("You have " + currentSugar + " servings of sugar on hand.");
            Console.WriteLine("You have " + currentIce + " cubes of ice on hand.");
            Console.WriteLine("You have " + currentCups + " cups on hand.");
            Console.ReadKey();
            UserAddToInventory();
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

