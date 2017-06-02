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
            Console.WriteLine("You open up you doors to " + player.playerName + "'s Lemonade Shop and flip the sign to 'OPEN'.");
            dailyPurchase.DisplayCurrentInventory();
            
        }
       
       public void CalculateSales()
        {
           List<Customer> customerList = todaysCustomers.GetCustomerList(todaysWeather);
            foreach (object customer in customerList)
            {
               Random random = new Random();
                int choice = random.Next(0, 100);
                if (choice > 29)
                {
                    dailyPurchase.SellOneCup();
                    Console.WriteLine(dailyPurchase.newPitcher.pitcherCups.Count());
                    Console.WriteLine("Lemonade sold!");
                }
            }
            Console.ReadLine();
        }
    }
}
