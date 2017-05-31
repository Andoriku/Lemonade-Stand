using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Weather todaysWeather = new Weather();
        Inventory Inventory = new Inventory();
        Pitcher Pitcher = new Pitcher();
        public void GetTodaysWeather()
        {
            todaysWeather.GetCurrentWeather();;
        }

        public void GetInventory()
        {
            Inventory.GetNewCupInventory();
            Inventory.GetNewLemonInventory();
            Inventory.GetNewIceInventory();
            Inventory.GetNewSugarInventory();
            Inventory.GetNewBudget();
        }
        public void GetRecipe()
        {
            Inventory.GetPitcher();
        }
        public void MakeNewPitcher()
        {
             Inventory.NewPitcher.Pour10Cups();
            Console.WriteLine(Inventory.lemonInventory + " " + Inventory.iceCubeInventory + " " + Inventory.sugarInventory);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Inventory.NewPitcher.PitcherList[i]);
            }
                Console.ReadLine();
        }
    }
}
