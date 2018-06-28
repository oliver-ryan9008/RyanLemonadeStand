﻿using System;
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
        Random random;
        public int totalCups = Store.totalCups;
        public int totalLemons = Store.totalLemons;
        public int totalSugar = Store.totalSugar;
        public int totalIce = Store.totalIce;
        public int combinedWeather = Day.combinedWeather;
        public static string randomTemperature = Day.randomTemperature.ToString();
        public static string randomConditions = Day.randomConditions.ToString();
        public void RunGame()
        {

        }
        public void RandomNumberGenerator(Random random)
        {
            this.random = random;
        }

        public int GenerateRandomNumber(int min, int max)
        {
            random = new Random();
            int randomNumber = random.Next(min, max);
            return randomNumber;
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
            Player player = new Player();
            Store store = new Store();
            Day day = new Day();
            Customer customer = new Customer();
            UI.DisplayBackroomInventory();
            day.TemperatureGenerator();
            day.ConditionsGenerator();
            customer.CustomersPurchaseRate();
            UI.DisplayTodaysWeather(day);
            store.BuyLemons();
            store.BuyIce();
            store.BuySugar();
            store.BuyCups();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            store.AddTotalCupsNumber();
            store.AddTotalLemonsNumber();
            store.AddTotalSugarNumber();
            store.AddTotalIceNumber();
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
