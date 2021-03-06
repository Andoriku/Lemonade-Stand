﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NewCups
    {
        TotalInventory totalInventory;
        private int BoughtCups;
        public static double cupPrice;
        public NewCups(TotalInventory totalInventory)
        {
            this.totalInventory = totalInventory;
        }
        public int GetCups()
        {
            Console.WriteLine("How many Cups do you want to buy today? Each cup is $0.05. Enter the number of cups you want to buy today.");
            try
            {
                BoughtCups = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Oops, thats not a valid number! try again.");
                GetCups();
            }
            double cupPrice = BoughtCups * .05;
            if (cupPrice < totalInventory.budget)
            {
                Console.WriteLine("You bought " + BoughtCups + " cups for $" + cupPrice);
                return BoughtCups;
            }
            else if (cupPrice > totalInventory.budget)
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
