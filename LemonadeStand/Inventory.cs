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
        public Pitcher NewPitcher = new Pitcher();

        public double budget = 40;
        public double cupPrice;
        public int boughtCups;
        public int cupInventory = 0;
        public double lemonPrice;
        public int boughtLemons;
        public double lemonInventory = 0;
        public double sugarPrice;
        public int boughtSugar;
        public double sugarInventory = 0;
        public double iceCubePrice;
        public int boughtIceCubes;
        public double iceCubeInventory = 0;


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
        public double GetNewLemonInventory()
        {
            lemonInventory += boughtLemons;
            Console.WriteLine("You have " + lemonInventory + " lemons.");
            return lemonInventory;
        }
        public double GetNewSugarInventory()
        {
            sugarInventory += boughtSugar;
            Console.WriteLine("You have " + sugarInventory + " cups of sugar.");
            return sugarInventory;
        }
        public double GetNewIceInventory()
        {
            iceCubeInventory += boughtIceCubes;
            Console.WriteLine("You have " + iceCubeInventory + " ice cubes.");
            return iceCubeInventory;
        }
        public double GetNewBudget()
        {
            budget -= (cupPrice + lemonPrice + sugarPrice + iceCubePrice);
            Math.Round(budget, 2);
            Console.WriteLine("you have $" + budget + " left.");
            Console.ReadLine();
            return budget;
        }
        public void GetPitcher()
        {
            NewPitcher.ChoseCupsOfSugarAmount();
            double recipeSugar = NewPitcher.numberOfCupsOfSugar;
            sugarInventory -= recipeSugar;
            NewPitcher.ChoseLemonAmount();
            double recipeLemons = NewPitcher.numberOfLemons;
            lemonInventory -= recipeLemons;
            NewPitcher.ChoseNumberOfIceCubes();
            double recipeIce = NewPitcher.numberOfIceCubes;
            iceCubeInventory -= recipeIce;
  
        }

    }
}
