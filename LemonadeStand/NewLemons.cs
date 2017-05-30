using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NewLemons
    {
        public int BoughtLemons;
        public double lemonPrice;
        public int GetLemons()
        {
            Console.WriteLine("How many Lemons do you want? enter a number.");
            BoughtLemons = Convert.ToInt32(Console.ReadLine());
            double lemonPrice = BoughtLemons * .65;
            Console.WriteLine("You bought " + BoughtLemons + " cups for $" + lemonPrice);
            return BoughtLemons;
        }
        public double GetPriceOfLeomons()
        {
            lemonPrice = BoughtLemons * .65;
            return lemonPrice;
        }
    }
}
