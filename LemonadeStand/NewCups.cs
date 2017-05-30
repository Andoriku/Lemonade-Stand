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
        public double cupPrice;
        public int GetCups()
        {
            Console.WriteLine("How many Cups do you want today? enter a number.");
            BoughtCups = Convert.ToInt32(Console.ReadLine());
            double cupPrice = BoughtCups * .05;
            Console.WriteLine("You bought " + BoughtCups + " cups for $" + cupPrice);
            return BoughtCups;
        }
        public double GetPriceOfCups()
        {
            cupPrice = BoughtCups * .05;
            return cupPrice;
        }
    }
}
