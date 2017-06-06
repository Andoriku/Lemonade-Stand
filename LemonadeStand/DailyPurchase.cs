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
        NewIce newIce;
        NewSugar newSugar;
        public Pitcher newPitcher;
        public double todaysNetSales;
        public int boughtCups;
        public double cupPrice;
        public double lemonPrice;
        public int boughtLemons;
        public double recipeLemons;
        public double sugarPrice;
        public int boughtSugar;
        public double recipeSugar;
        public double iceCubePrice;
        public int boughtIceCubes;
        public double recipeIce;
        public double salePrice;
        public bool lastPicther;
        public double passedSales;




        public DailyPurchase(TotalInventory totalInventory)
        {
            this.totalInventory = totalInventory;
            newLemons = new NewLemons(totalInventory);
            newCups = new NewCups(totalInventory);
            newSugar = new NewSugar(totalInventory);
            newIce = new NewIce(totalInventory);
            newPitcher = new Pitcher();
            todaysNetSales = passedSales;         
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
                totalInventory.budget = Math.Round(totalInventory.budget, 2);
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
                    newIce.GetIceCubes();
                    newIce.GetPriceOfIceCubes();
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
            boughtIceCubes = newIce.GetIceCubes();
            iceCubePrice = newIce.GetPriceOfIceCubes();
            GetNewIceInventory();
            GetNewBudget(iceCubePrice);
        }
        public void DisplayInventory()
        {
            Console.WriteLine("your Total Inventory: \n -Cups: " + totalInventory.cupInventory + "\n -Lemons: " + totalInventory.lemonInventory + "\n -Cups Of Sugar: " + totalInventory.sugarInventory + "\n -Ice Cubes: " + totalInventory.iceCubeInventory + "\n -Remaining Budget: " + totalInventory.budget);
        }
        public void GetPitcher()
        {
           
            newPitcher.ChoseCupsOfSugarAmount();
            recipeSugar = newPitcher.numberOfCupsOfSugar;
            if (totalInventory.sugarInventory >= recipeSugar)
            {
                totalInventory.sugarInventory -= recipeSugar;
                EndSales();
            }
            else
            {
                Console.WriteLine("You dont have enough Sugar, You can't make a new pitcher!");
                DisplayCurrentInventory();
                EndSales();
            }

            newPitcher.ChoseLemonAmount();
            recipeLemons = newPitcher.numberOfLemons;
            if (totalInventory.lemonInventory >= recipeLemons)
            {
                totalInventory.lemonInventory -= recipeLemons;
                EndSales();
            }
            else
            {
                Console.WriteLine("You dont have enough Lemons, You can't make a new pitcher!");
                DisplayCurrentInventory();
                EndSales();
            }
            
            
            newPitcher.ChoseNumberOfIceCubes();
            recipeIce = newPitcher.numberOfIceCubes;
            if (totalInventory.iceCubeInventory >= recipeIce)
            {
                totalInventory.iceCubeInventory -= recipeIce;
                EndSales();
            }
            else
            {
                Console.WriteLine("You dont have enough Ice, You can't make a new pitcher!");
                DisplayCurrentInventory();
                EndSales();
            }

            if (totalInventory.cupInventory >= 10)
            {
                totalInventory.cupInventory -= 10;
                EndSales();
            }
            else
            {
                Console.WriteLine("You dont have enough Cups, You can't make a new pitcher!");
                DisplayCurrentInventory();
                EndSales();
            }

            salePrice = newPitcher.GetCupPrice();
        }
        public void DisplayCurrentInventory()
        {
            Console.WriteLine("You've made a pitcher. Here is your updated Inventory:");
            Console.WriteLine("- Your remaining Cups Of Sugar: " + totalInventory.sugarInventory);
            Console.WriteLine("- Your remaining Lemons: " + totalInventory.lemonInventory);
            Console.WriteLine("- Your remaining Ice Cubes " + totalInventory.iceCubeInventory);
        }
        
        public bool EndSales()
        {
            bool lastPitcher = true;
if (totalInventory.cupInventory <= 10)
            {
                lastPitcher = false;
                return lastPitcher;
            }
else if (totalInventory.iceCubeInventory <= 0)
            {
                lastPitcher = false;
                return lastPitcher;
            }
else if (totalInventory.lemonInventory <= 0)
            {
                lastPitcher = false;
                return lastPitcher;
            }
else if (totalInventory.sugarInventory <= 0)
            {
                lastPitcher = false;
                return lastPitcher;
            }
else
            {
                lastPitcher = true;
                return lastPitcher;
            }
        }
        public void SellOneCup()
        {
            
            if (newPitcher.pitcherCups == null || newPitcher.pitcherCups.Count == 0)
            {
                if (totalInventory.cupInventory < 10 || totalInventory.iceCubeInventory < 1 || totalInventory.lemonInventory < 1 || totalInventory.sugarInventory < 1)
                {
                    Console.WriteLine("You've run out of ingrediants!");
                    DisplaySales();
                }
                else
                {
                    newPitcher = new Pitcher();
                    GetPitcher();
                    DisplayCurrentInventory();
                    Console.ReadLine();
                    SellOneCup();
                }
            }
            else
            {
                newPitcher.pitcherCups.RemoveAt(0);
                totalInventory.budget += salePrice;
                todaysNetSales += salePrice;
            }
        }
        public void DisplaySales()
        {
            Console.WriteLine("Your total sales for today were: $" + todaysNetSales);
            Console.WriteLine("Your new Budget after sales is: $" + totalInventory.budget);
            Console.ReadLine();
        }
    }
}
