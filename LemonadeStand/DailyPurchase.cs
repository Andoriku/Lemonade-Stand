using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DailyPurchase
    {
        TotalInventory totalInventory = new TotalInventory();
        NewCups NewCups = new NewCups();
        NewLemons NewLemons = new NewLemons();
        NewIce NewIce = new NewIce();
        NewSugar NewSugar = new NewSugar();
        public Pitcher NewPitcher = new Pitcher();

        public int boughtCups;
        public double cupPrice;
        public double lemonPrice;
        public int boughtLemons;
        public double sugarPrice;
        public int boughtSugar;
        public double iceCubePrice;
        public int boughtIceCubes;

        public DailyPurchase()
        {

        }
        public void DefineDailyPurchase()
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
            totalInventory.cupInventory += boughtCups;
            Console.WriteLine("You have " + totalInventory.cupInventory + " cups.");
            return totalInventory.cupInventory;
        }
        public double GetNewLemonInventory()
        {
            totalInventory.lemonInventory += boughtLemons;
            Console.WriteLine("You have " + totalInventory.lemonInventory + " lemons.");
            return totalInventory.lemonInventory;
        }
        public double GetNewSugarInventory()
        {
            totalInventory.sugarInventory += boughtSugar;
            Console.WriteLine("You have " + totalInventory.sugarInventory + " cups of sugar.");
            return totalInventory.sugarInventory;
        }
        public double GetNewIceInventory()
        {
            totalInventory.iceCubeInventory += boughtIceCubes;
            Console.WriteLine("You have " + totalInventory.iceCubeInventory + " ice cubes.");
            return totalInventory.iceCubeInventory;
        }
        public double GetNewBudget(double price)
        {
            if (price < TotalInventory.budget)
            {
                TotalInventory.budget -= (price);
                Math.Round(TotalInventory.budget, 2);
                Console.WriteLine("you have $" + TotalInventory.budget + " left.");
                Console.ReadLine();
                return TotalInventory.budget;
            }
            else if (price > TotalInventory.budget)
            {
                Console.WriteLine("You dont have enough funds left!");
                Console.ReadLine();
                if (price == cupPrice)
                {
                    boughtCups = 0;                    
                    NewCups.GetCups();
                    NewCups.GetPriceOfCups();
                    double newCupPrice = NewCups.cupPrice;
                    GetNewBudget(newCupPrice);
                }
                else if (price == sugarPrice)
                {
                    boughtSugar = 0;
                   NewSugar.GetSugar();
                    NewSugar.GetPriceOfSugar();
                    double newSugarPrice = NewSugar.sugarPrice;
                    GetNewBudget(newSugarPrice);
                }
                else if (price == lemonPrice)
                {
                    boughtLemons = 0;
                    NewLemons.GetLemons();
                    NewLemons.GetPriceOfLeomons();
                    double newLemonPrice = NewLemons.lemonPrice;
                    GetNewBudget(newLemonPrice);
                }
                else if (price == iceCubePrice)
                {
                    boughtIceCubes = 0;
                    NewIce.GetIceCubes();
                    NewIce.GetPriceOfIceCubes();
                    double newIceCubePrice = NewIce.iceCubePrice;
                    GetNewBudget(newIceCubePrice);
                }
            }
            return TotalInventory.budget;
        }
        public void GetPitcher()
        {
            NewPitcher.ChoseCupsOfSugarAmount();
            double recipeSugar = NewPitcher.numberOfCupsOfSugar;
            totalInventory.sugarInventory -= recipeSugar;

            NewPitcher.ChoseLemonAmount();
            double recipeLemons = NewPitcher.numberOfLemons;
            totalInventory.lemonInventory -= recipeLemons;

            NewPitcher.ChoseNumberOfIceCubes();
            double recipeIce = NewPitcher.numberOfIceCubes;
            totalInventory.iceCubeInventory -= recipeIce;

            NewPitcher.GetCupPrice();
        }

    }
}
