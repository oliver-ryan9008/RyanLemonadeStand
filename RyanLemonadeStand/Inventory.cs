using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{

    public class Inventory
    {
        public int currentCups = 0;
        public int currentIce = 0;
        public int currentLemons = 0;
        public int currentSugar = 0;
        public bool enoughInventory;
        public int lemonInventory;
        public int iceInventory;
        public int sugarInventory;
        public int cupsInventory;
        public double moneyOnHand = 20.00;
        public int totalLemonadeCreated;
        public double profit;

        public void SellingInventoryCalculation()
        {
            currentLemons = currentLemons - 1;
            currentIce = currentIce - 1;
            currentSugar = currentSugar - 1;
            currentCups = currentCups - 1;
        }

        public void LemonadeInventory()
        {
            if (lemonInventory > 0 && iceInventory > 0 && sugarInventory > 0 && cupsInventory > 0)
            {
                
            }
        }

        public bool InventoryCheck()
        {
            if (lemonInventory > 0 && iceInventory > 0 && sugarInventory > 0 && cupsInventory > 0)
            {
                enoughInventory = true;
            }
            else
            {
                enoughInventory = false;
                Console.WriteLine("STORE CLOSED: You do not have enough inventory to serve your customers. You need to purchase more materials before you can reopen your store.");
            }
            return enoughInventory;
        }
    }


}
