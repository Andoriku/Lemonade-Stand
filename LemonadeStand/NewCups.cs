using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NewCups
    {
        public int BoughtCups;
        public static double cupPrice;
        public int GetCups()
        {
            Console.WriteLine("How many Cups do you want today? Each cup is $0.05. Enter the number of cups you want to buy today.");
            BoughtCups = Convert.ToInt32(Console.ReadLine());
            double cupPrice = BoughtCups * .05;
            if (cupPrice < TotalInventory.budget)
            {
                Console.WriteLine("You bought " + BoughtCups + " cups for $" + cupPrice);
                return BoughtCups;
            }
            else if (cupPrice > TotalInventory.budget)
                    {
                Console.WriteLine("You do not have enough to buy that many cups! try again.");
                return GetCups();
            }
            else
            {
                Console.WriteLine("You bought " + BoughtCups + " cups for $" + cupPrice);
                return BoughtCups;
            }
        }
        public double GetPriceOfCups()
        {
            cupPrice = BoughtCups * .05;
            return cupPrice;
        }
    }
}
