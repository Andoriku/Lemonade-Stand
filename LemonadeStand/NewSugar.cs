using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NewSugar
    {
        public int BoughtSugar;
        public double sugarPrice;
        public int GetSugar()
        {
            Console.WriteLine("How many Cups Of Sugar do you want today? Enter a number.");
            BoughtSugar = Convert.ToInt32(Console.ReadLine());
            sugarPrice = BoughtSugar * .67;
            Console.WriteLine("You bought " + BoughtSugar + " cups of sugar for $" + sugarPrice);
            return BoughtSugar;
        }
        public double GetPriceOfSugar()
        {
            sugarPrice = BoughtSugar * .67;
            return sugarPrice;
        }
    }
}
