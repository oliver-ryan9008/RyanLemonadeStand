using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    class Game
    {
        
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
            Console.WriteLine("Let's start by purchasing some materials for your inventory!\n Press any key to start purchasing materials!");
            Console.ReadKey();
            UI.BuyLemons();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            UI.DisplayInventory();
            
            //store.BuySugar();
            //store.BuyIce();
            //store.BuyCups();

        }

        //public void DisplayInventory()
        //{
        //    Console.WriteLine("This is where inventory will show once I get it working.");
        //    Console.ReadKey();
            
        //}
    }
}
