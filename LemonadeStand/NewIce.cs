using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NewIce
    {
        public int BoughtIceCubes;
        public double iceCubePrice;
        public int GetIceCubes()
        {
            Console.WriteLine("How many Ice Cubes do you want today? enter a number.");
            BoughtIceCubes = Convert.ToInt32(Console.ReadLine());
            double iceCubePrice = BoughtIceCubes * .03;
            Console.WriteLine("You bought " + BoughtIceCubes + " ice cubes for $" + iceCubePrice);
            return BoughtIceCubes;
        }
        public double GetPriceOfIceCubes()
        {
            iceCubePrice = BoughtIceCubes * .03;
            return iceCubePrice;
        }
    }
}
