using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanLemonadeStand
{
    public class Player
    {
        public double moneyOnHand = 20.00;
        public double profit;

        public Player()
        {

        }

        public void CurrentWalletTotal()
        {
               

        }
        public void PlayerInventory(Store store)
        {
            int lemonInventory;
            int iceInventory;
            int sugarInventory;
            int cupsInventory;
        }

        public void ProfitCalculator(Customer customer, Store store)
        {
            profit = customer.totalDaySales * store.lemonadeCupPrice - store.moneySpent;
        }
        

    }
        
}

