using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        NewCups NewCups = new NewCups();
        NewLemons NewLemons = new NewLemons();

        public double budget = 40;
        public double cupPrice;
        public int boughtCups;
        public int cupInventory = 0;
        public double lemonPrice;
        public int boughtLemons;
        public int lemonInventory = 0;

        public Inventory()
        {
            boughtCups = NewCups.GetCups();
            cupPrice = NewCups.GetPriceOfCups();
            boughtLemons = NewLemons.GetLemons();
            lemonPrice = NewLemons.GetPriceOfLeomons();

        }
        public int GetNewCupInventory()
        {
            cupInventory += boughtCups;
            return cupInventory;
        }
        public int GetNewLemonInventory()
        {
             lemonInventory += boughtLemons;
            return lemonInventory;
        }
        public double GetNewBudget()
        {
            budget -= (cupPrice + lemonPrice);
            Console.WriteLine("you have $" + budget + " left.");
            Console.Read();
            return budget;
        }
    }
}
