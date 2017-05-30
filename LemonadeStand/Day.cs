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
  
        public void GetTodaysWeather()
        {
            todaysWeather.GetCurrentWeather();
        }

        public void GetInventory()
        {
            Inventory.GetNewCupInventory();
            Inventory.GetNewLemonInventory();
            Inventory.GetNewIceInventory();
            Inventory.GetNewSugarInventory();
            Inventory.GetNewBudget();
        }
        
    }
}
