using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public static class UI
    {
        //public static int currentCups = Player.currentCups;
        //public static int currentIce = Player.currentIce;
        //public static int currentSugar = Player.currentSugar;
        //public static int currentLemons = Player.currentLemons;
        //public static int totalLemons;
        //public static int totalIce;
        //public static int totalSugar;
        //public static int totalCups;
        //public static int combinedWeather = Day.combinedWeather;
        //public static int randomTemperature = Day.randomTemperature;
        //public static int randomConditions = Day.randomConditions;


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

        public static void DisplayBackroomInventory(Player player)
        {
            Console.WriteLine("You have " + player.currentLemons + " lemons on hand.");
            Console.WriteLine("You have " + player.currentSugar + " servings of sugar on hand.");
            Console.WriteLine("You have " + player.currentIce + " cubes of ice on hand.");
            Console.WriteLine("You have " + player.currentCups + " cups on hand.");
            Console.ReadKey();
            
        }

        public static void DisplayRestockedInventory(Player player, Store store)
        {
            
            Console.WriteLine("After all purchases you have " + store.totalLemons + " lemons in your inventory.");
            Console.WriteLine("After all purchases you have " + store.totalSugar + " servings of sugar in your inventory.");
            Console.WriteLine("After all purchases you have " + store.totalIce + " cubes of ice in your inventory.");
            Console.WriteLine("After all purchases you have " + store.totalCups + " cups in your inventory.");
        }

        public static void DisplayTodaysWeather(Day day)
        {
            if (day.combinedWeather == 2)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's not a very good day for sales!");
            }
            else if (day.combinedWeather == 3)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's not a very good day for sales!");
            }
            else if (day.combinedWeather == 4)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's an average day for sales!");
            }
            else if (day.combinedWeather == 5)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's an average day for sales!");
            }
            else if (day.combinedWeather == 6)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's an average day for sales!");
            }
            else if (day.combinedWeather == 7)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's an average day for sales!");
            }
            else if (day.combinedWeather == 8)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's a pretty good day for sales!");
            }
            else if (day.combinedWeather == 9)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's not an excellent day for sales!");
            }
            else if (day.combinedWeather == 10)
            {
                Console.WriteLine("The weather today is " + day.randomTemperature + " degrees Fahrenheit and " + day.randomConditions + ". It's the perfect day for sales!");
            }
        }



        
            

            

        
        
        


        

            

        
    }
}

