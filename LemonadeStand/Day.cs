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
            int i = 0;
            foreach (object customer in customerList)
            {
                int choice;
                Random random = new Random();
                if (customerList[i].customerProfile == 1)
                {
                    if (customerList[i].customerLemonPreference == dailyPurchase.recipeLemons && customerList[i].customerSugarPreference == dailyPurchase.recipeSugar)
                    {
                        dailyPurchase.SellOneCup();
                        Console.WriteLine(dailyPurchase.newPitcher.pitcherCups.Count());
                        Console.WriteLine("Lemonade sold!");
                        i++;
                    }
                    else
                    {
                        choice = random.Next(0, 20);
                        if (choice > 15 && dailyPurchase.salePrice <= customerList[i].customerPricePreference)
                        {
                            dailyPurchase.SellOneCup();
                            Console.WriteLine(dailyPurchase.newPitcher.pitcherCups.Count());
                            Console.WriteLine("Lemonade sold!");
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                else if (customerList[i].customerProfile == 2)
                {
                    if (customerList[i].customerLemonPreference == dailyPurchase.recipeLemons && customerList[i].customerSugarPreference == dailyPurchase.recipeSugar)
                    {
                        dailyPurchase.SellOneCup();
                        Console.WriteLine(dailyPurchase.newPitcher.pitcherCups.Count());
                        Console.WriteLine("Lemonade sold!");
                        i++;
                    }
                    else
                    {
                        choice = random.Next(0, 50);
                        if (choice > 25 && dailyPurchase.salePrice <= customerList[i].customerPricePreference)
                        {
                            dailyPurchase.SellOneCup();
                            Console.WriteLine(dailyPurchase.newPitcher.pitcherCups.Count());
                            Console.WriteLine("Lemonade sold!");
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                else if (customerList[i].customerProfile == 3)
                {
                    if (customerList[i].customerLemonPreference == dailyPurchase.recipeLemons && customerList[i].customerSugarPreference == dailyPurchase.recipeSugar)
                    {
                        dailyPurchase.SellOneCup();
                        Console.WriteLine(dailyPurchase.newPitcher.pitcherCups.Count());
                        Console.WriteLine("Lemonade sold!");
                        i++;
                    }
                    else
                    {
                        choice = random.Next(0, 100);
                        if (choice > 20 && dailyPurchase.salePrice <= customerList[i].customerPricePreference)
                        {
                            dailyPurchase.SellOneCup();
                            Console.WriteLine(dailyPurchase.newPitcher.pitcherCups.Count());
                            Console.WriteLine("Lemonade sold!");
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
