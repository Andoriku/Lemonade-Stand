using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NewSugar
    {
        TotalInventory totalInventory;
        public int boughtSugar;
        public static double sugarPrice;
        public NewSugar(TotalInventory totalInventory)
        {
            this.totalInventory = totalInventory;
        }
        public int GetSugar()
        {
            Console.WriteLine("How many Cups Of Sugar do you want today? Each cup of sugar is $0.67. Enter the number of cups you want to buy today.");
            boughtSugar = Convert.ToInt32(Console.ReadLine());
            sugarPrice = boughtSugar * .67;
            if (sugarPrice < totalInventory.budget)
            {
                Console.WriteLine("You bought " + boughtSugar + " cups for $" + sugarPrice);
                return boughtSugar;
            }
            else if (sugarPrice > totalInventory.budget)
            {
                Console.WriteLine("You do not have enough to buy that many cups! try again.");
                return GetSugar();
            }
            else
            {
                Console.WriteLine("You bought " + boughtSugar + " cups for $" + sugarPrice);
                return boughtSugar;
            }
        }
        public double GetPriceOfSugar()
        {
            sugarPrice = boughtSugar * .67;
            return sugarPrice;
        }
    }
}
