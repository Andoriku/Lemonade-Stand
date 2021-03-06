﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NewIce
    {
        TotalInventory totalInventory;
        private int BoughtIceCubes;
        public static double iceCubePrice;
        public NewIce(TotalInventory totalInventory)
        {
            this.totalInventory = totalInventory;
        }
        public int GetIceCubes()
        {
            Console.WriteLine("How many Ice Cubes do you want to buy today? Each ice cube is $0.03. Enter the number of ice cubes you want to buy today.");
            try
            {
                BoughtIceCubes = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Oops, thats not a valid number! try again.");
                GetIceCubes();
            }
            double iceCubePrice = BoughtIceCubes * .03;

            if (iceCubePrice < totalInventory.budget)
            {
                Console.WriteLine("You bought " + BoughtIceCubes + " ice cubes for $" + iceCubePrice);
                return BoughtIceCubes;
            }
            else if (iceCubePrice > totalInventory.budget)
            {
                Console.WriteLine("You do not have enough to buy that many ice cubes! try again.");
                return GetIceCubes();
            }
            else
            {
                Console.WriteLine("You bought " + BoughtIceCubes + " ice cubes for $" + iceCubePrice);
                return BoughtIceCubes;
            }
        }
        public double GetPriceOfIceCubes()
        {
            iceCubePrice = BoughtIceCubes * .03;
            return iceCubePrice;
        }
    }
}
