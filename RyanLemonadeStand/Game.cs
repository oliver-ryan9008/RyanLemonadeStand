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
                Console.WriteLine("Let's get started!");
                StartGame();
                Console.Clear();
            }
            else if(startGameChoice == "no")
            {
                Console.WriteLine("Alright. No problem. Play later? Just hit any key when you want to play!");
                Console.ReadKey();
                PromptForGame();
            }
        }

        public void StartGame()
        {

        }
    }
}
