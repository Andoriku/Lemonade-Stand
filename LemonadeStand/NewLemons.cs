using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NewLemons
    {
        TotalInventory totalInventory;
        public int boughtLemons;
        public static double lemonPrice;
        public NewLemons(TotalInventory totalInventory)
        {
            this.totalInventory = totalInventory;
        }
        public int GetLemons()
        {
            Console.WriteLine("How many Lemons do you want today? Each lemon is $0.65. Enter the number of lemons you want to buy today.");
            boughtLemons = Convert.ToInt32(Console.ReadLine());
            double lemonPrice = boughtLemons * .65;
            if (lemonPrice < totalInventory.budget)
            {
                Console.WriteLine("You bought " + boughtLemons + " cups for $" + lemonPrice);
                return boughtLemons;
            }
            else if (lemonPrice > totalInventory.budget)
            {
                Console.WriteLine("You do not have enough to buy that many cups! try again.");
                return GetLemons();
            }
            else
            {
                Console.WriteLine("You bought " + boughtLemons + " cups for $" + lemonPrice);
                return boughtLemons;
            }
        }
        public double GetPriceOfLeomons()
        {
            lemonPrice = boughtLemons * .65;
            return lemonPrice;
        }
    }
}
