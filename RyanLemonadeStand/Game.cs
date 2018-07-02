using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public class Game
    {

        //public static int cupsPurchased;
        //public static int lemonsPurchased;
        //public static int sugarPurchased;
        //public static int icePurchased;
        Random randomNumber;
        
        Store store = new Store();
        Day day = new Day();
        //public int totalCups = store.totalCups;
        //public int totalLemons = Store.totalLemons;
        //public int totalSugar = Store.totalSugar;
        //public int totalIce = Store.totalIce;
        //public int combinedWeather;
        //public string randomTemperature;
        //public string randomConditions;
        public int min;
        public int max;

        public void RunGame()
        {

        }
        //public void RandomNumberGenerator(Random random)
        //{
        //    this.randomNumber = random;
        //}

        //public void GenerateRandomNumber(int min, int max)
        //{
        //    this.randomNumber = new Random();
        //    int randomNumber = randomNumber.Next(min, max);
        //    return randomNumber;
        //}


        public void PromptForGame()
        {
            Console.Clear();
            Console.WriteLine("Let's play a game of Lemonade Stand! Enter yes to start the game or no to quit!");

            String startGameChoice;
            startGameChoice = Console.ReadLine().ToLower();
            if (startGameChoice == "yes")
            {
                Console.Clear();
                Console.WriteLine("Let's get started!");
                StartGame();

            }
            else if (startGameChoice == "no")
            {
                Console.Clear();
                Console.WriteLine("Alright. No problem. Play later? Just hit any key when you want to play!");
                Console.ReadKey();
                PromptForGame();
            }
        }

        public void StartGame()
        {
            Player player = new Player();
            Store store = new Store();
            Day day = new Day();            
            Customer customer = new Customer();
            Random random = new Random();
            UI.DisplayBackroomInventory(player);
            day.TemperatureGenerator();
            day.ConditionsGenerator();
            customer.CustomerPurchaseRate(min, max, day);
            UI.DisplayTodaysWeather(day);
            store.BuyLemons();
            store.BuyIce();
            store.BuySugar();
            store.BuyCups();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            store.AddTotalCupsNumber(player);
            store.AddTotalLemonsNumber(player);
            store.AddTotalSugarNumber(player);
            store.AddTotalIceNumber(player);
            UI.DisplayRestockedInventory(player, store);
            day.TemperatureGenerator();
            day.ConditionsGenerator();
            day.Weather();
            customer.GenerateCustomers(day, min, max);
            customer.CustomerPurchaseRate(min, max, day);
            UI.DisplayTotalCustomerPurchases(customer);
            Console.WriteLine("End of code so far.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("End of game. Press a key to close game.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
