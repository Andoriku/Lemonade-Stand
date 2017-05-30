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
        NewIce NewIce = new NewIce();
        NewSugar NewSugar = new NewSugar();

        public double budget = 40;
        public double cupPrice;
        public int boughtCups;
        public int cupInventory = 0;
        public double lemonPrice;
        public int boughtLemons;
        public int lemonInventory = 0;
        public double sugarPrice;
        public int boughtSugar;
        public int sugarInventory = 0;
        public double iceCubePrice;
        public int boughtIceCubes;
        public int iceCubeInventory = 0;


        public Inventory()
        {
            boughtCups = NewCups.GetCups();
            cupPrice = NewCups.GetPriceOfCups();
            boughtLemons = NewLemons.GetLemons();
            lemonPrice = NewLemons.GetPriceOfLeomons();
            boughtSugar = NewSugar.GetSugar();
            sugarPrice = NewSugar.GetPriceOfSugar();
            boughtIceCubes = NewIce.GetIceCubes();
            iceCubePrice = NewIce.GetPriceOfIceCubes();

        }
        public int GetNewCupInventory()
        {
            cupInventory += boughtCups;
            Console.WriteLine("You have " + cupInventory + " cups.");
            return cupInventory;
        }
        public int GetNewLemonInventory()
        {
             lemonInventory += boughtLemons;
            Console.WriteLine("You have " + lemonInventory + " lemons.");
            return lemonInventory;
        }
        public int GetNewSugarInventory()
        {
            sugarInventory += boughtSugar;
            Console.WriteLine("You have " + sugarInventory + " cups of sugar.");
            return sugarInventory;
        }
        public int GetNewIceInventory()
        {
            iceCubeInventory += boughtIceCubes;
            Console.WriteLine("You have " + iceCubeInventory + " ice cubes.");
            return iceCubeInventory;
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
