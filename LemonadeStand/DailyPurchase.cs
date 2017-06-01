using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DailyPurchase
    {
        TotalInventory totalInventory;
        NewCups newCups;
        NewLemons newLemons;
        NewIce NewIce = new NewIce();
        NewSugar newSugar;
        public Pitcher NewPitcher = new Pitcher();

        public int boughtCups;
        public double cupPrice;
        public double lemonPrice;
        public int boughtLemons;
        public double sugarPrice;
        public int boughtSugar;
        public double iceCubePrice;
        public int boughtIceCubes;

        public DailyPurchase(TotalInventory totalInventory)
        {
            this.totalInventory = totalInventory;
            newLemons = new NewLemons(totalInventory);
            newCups = new NewCups(totalInventory);
            newSugar = new NewSugar(totalInventory);

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
            if (price < totalInventory.budget)
            {
                totalInventory.budget -= (price);
                Math.Round(totalInventory.budget, 2);
                Console.WriteLine("you have $" + totalInventory.budget + " left.");
                Console.ReadLine();
                return totalInventory.budget;
            }
            else if (price > totalInventory.budget)
            {
                Console.WriteLine("You dont have enough funds left!");
                Console.ReadLine();
                if (price == cupPrice)
                {
                    boughtCups = 0;                    
                    newCups.GetCups();
                    newCups.GetPriceOfCups();
                    double newCupPrice = NewCups.cupPrice;
                    GetNewBudget(newCupPrice);
                }
                else if (price == sugarPrice)
                {
                    boughtSugar = 0;
                   newSugar.GetSugar();
                    newSugar.GetPriceOfSugar();
                    double newSugarPrice = NewSugar.sugarPrice;
                    GetNewBudget(newSugarPrice);
                }
                else if (price == lemonPrice)
                {
                    boughtLemons = 0;
                    newLemons.GetLemons();
                    newLemons.GetPriceOfLeomons();
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
            return totalInventory.budget;
        }
        public void GetTodaysCups()
        {
            boughtCups = newCups.GetCups();
            cupPrice = newCups.GetPriceOfCups();
            GetNewCupInventory();
            GetNewBudget(cupPrice);
        }
        public void GetTodaysLemons()
        {
            boughtLemons = newLemons.GetLemons();
            lemonPrice = newLemons.GetPriceOfLeomons();
            GetNewLemonInventory();
            GetNewBudget(lemonPrice);
        }
        public void GetTodaysCupsOfSugar()
        {
            boughtSugar = newSugar.GetSugar();
            sugarPrice = newSugar.GetPriceOfSugar();
            GetNewSugarInventory();
            GetNewBudget(sugarPrice);
        }
        public void GetTodaysIce()
        {
            boughtIceCubes = NewIce.GetIceCubes();
            iceCubePrice = NewIce.GetPriceOfIceCubes();
            GetNewIceInventory();
            GetNewBudget(iceCubePrice);
        }
        public void DisplayInventory()
        {
            Console.WriteLine("your Total Inventory: \n-Cups: " + totalInventory.cupInventory + "\n-Lemons: " + totalInventory.lemonInventory + "\n-Cups Of Sugar: " + totalInventory.sugarInventory + "\n-Ice Cubes: " + totalInventory.iceCubeInventory);
            Console.ReadLine();
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
