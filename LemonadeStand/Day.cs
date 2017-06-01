using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        DailyPurchase dailyPurchase;
        Weather todaysWeather = new Weather();
        CustomerList todaysCustomers = new CustomerList();
        Player player;
        public Day(Player player)
        {
            this.player = player;
            dailyPurchase = new DailyPurchase(player.totalInventory);
        }
        public void GetTodaysWeather()
        {
            todaysWeather.GetCurrentWeather();
            todaysWeather.DipslayCurrentWeather(todaysWeather.currentWeather);
        }

        public void GetInventory()
        {
            dailyPurchase.GetTodaysCups();
            dailyPurchase.GetTodaysLemons();
            dailyPurchase.GetTodaysCupsOfSugar();
            dailyPurchase.GetTodaysIce();
            dailyPurchase.DisplayInventory();
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
