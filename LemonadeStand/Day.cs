using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        DailyPurchase dailyPurchase = new DailyPurchase();
        Weather todaysWeather = new Weather();
        CustomerList todaysCustomers = new CustomerList();
        public void GetTodaysWeather()
        {
            todaysWeather.GetCurrentWeather();
            todaysWeather.DipslayCurrentWeather(todaysWeather.currentWeather);
        }

        public void GetInventory()
        {
            dailyPurchase.DefineDailyPurchase();
            dailyPurchase.GetNewCupInventory();
            dailyPurchase.GetNewLemonInventory();
            dailyPurchase.GetNewIceInventory();
            dailyPurchase.GetNewSugarInventory();
            dailyPurchase.GetNewBudget();
        }
        public void GetRecipe()
        {
            dailyPurchase.GetPitcher();
        }
        public void MakeNewPitcher()
        {
            dailyPurchase.NewPitcher.Pour10Cups();
        }
        public void GetTodaysCustomers()
        {
            todaysCustomers.GetCustomerList(todaysWeather);
        }
    }
}
