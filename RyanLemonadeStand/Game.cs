using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    class Game
    {

        //public static int cupsPurchased;
        //public static int lemonsPurchased;
        //public static int sugarPurchased;
        //public static int icePurchased;
        public int totalCups = Store.totalCups;
        public int totalLemons = Store.totalLemons;
        public int totalSugar = Store.totalSugar;
        public int totalIce = Store.totalIce;
        int buyerPurchasedCups = Store.cupsPurchased;
        int buyerPurchasedLemons = Store.lemonsPurchased;
        int buyerPurchasedIce = Store.icePurchased;
        int buyerPurchasedSugar = Store.sugarPurchased;

        public void RunGame()
        {

        }
        public void PromptForGame()
        {
            Console.Clear();
            Console.WriteLine("Let's play a game of Lemonade Stand! Enter yes to start the game or no to quit!");
            
            String startGameChoice;
            startGameChoice = Console.ReadLine().ToLower();
            if(startGameChoice == "yes")
            {
                Console.Clear();
                Console.WriteLine("Let's get started!");
                StartGame();
                
            }
            else if(startGameChoice == "no")
            {
                Console.Clear();
                Console.WriteLine("Alright. No problem. Play later? Just hit any key when you want to play!");
                Console.ReadKey();
                PromptForGame();
            }
        }

        public void StartGame()
        {
            Store store = new Store();
            UI.UserAddToInventory();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Store.AddTotalCupsNumber(buyerPurchasedCups, Player.currentCups);
            Store.AddTotalLemonsNumber(buyerPurchasedLemons, Player.currentLemons);
            Store.AddTotalSugarNumber(buyerPurchasedSugar, Player.currentSugar);
            Store.AddTotalIceNumber(buyerPurchasedIce, Player.currentIce);
            UI.DisplayRestockedInventory(totalCups, totalSugar, totalIce, totalLemons);
            Console.WriteLine("End of code so far.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("End of game. Press a key to close game.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
