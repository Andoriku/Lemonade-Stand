﻿using System;
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
        public double dailyNetSales;
        public Day(Player player)
        {
            this.player = player;
            dailyPurchase = new DailyPurchase(player.totalInventory);
            dailyNetSales = dailyPurchase.passedSales;
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
        public void DisplayTodaysSales()
        {
            dailyPurchase.DisplaySales();
        }
        public void CalculateSales()
        {


            List<Customer> customerList = todaysCustomers.GetCustomerList(todaysWeather);
            do
            {
                foreach (Customer customer in customerList)
                {
                    int choice;
                    Random random = new Random();
                    if (customer.customerProfile == 1)
                    {
                        if (customer.customerLemonPreference == dailyPurchase.recipeLemons && customer.customerSugarPreference == dailyPurchase.recipeSugar)
                        {
                            dailyPurchase.SellOneCup();
                            Console.WriteLine("Lemonade sold!");
                        }
                        else
                        {
                            choice = random.Next(0, 50);
                            if (choice > 15 && dailyPurchase.salePrice <= customer.customerPricePreference)
                            {
                                dailyPurchase.SellOneCup();
                                Console.WriteLine("Lemonade sold!");
                            }
                        }
                    }
                    else if (customer.customerProfile == 2)
                    {
                        if (customer.customerLemonPreference == dailyPurchase.recipeLemons && customer.customerSugarPreference == dailyPurchase.recipeSugar)
                        {
                            dailyPurchase.SellOneCup();
                            Console.WriteLine("Lemonade sold!");

                        }
                        else
                        {
                            choice = random.Next(0, 50);
                            if (choice > 19 && dailyPurchase.salePrice <= customer.customerPricePreference)
                            {
                                dailyPurchase.SellOneCup();
                                Console.WriteLine("Lemonade sold!");

                            }
                        }
                    }
                    else if (customer.customerProfile == 3)
                    {
                        if (customer.customerLemonPreference == dailyPurchase.recipeLemons && customer.customerSugarPreference == dailyPurchase.recipeSugar)
                        {
                            dailyPurchase.SellOneCup();
                            Console.WriteLine("Lemonade sold!");

                        }
                        else
                        {
                            choice = random.Next(0, 100);
                            if (choice > 15 && dailyPurchase.salePrice <= customer.customerPricePreference)
                            {
                                dailyPurchase.SellOneCup();
                                Console.WriteLine("Lemonade sold!");

                            }
                        }
                    }
                }
            }
            while (dailyPurchase.lastPicther == true);
        }
    }

}
