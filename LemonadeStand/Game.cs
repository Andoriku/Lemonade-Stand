using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        private double totalNetSales;
        private double profit;
       
        Day round; 
        public void RunMenu()
        {
            Console.WriteLine("Welcome to Lemonade Stand. What would you like to do? \n-Start New Game (new) \n-Load Game (load) \n-Rules (rules) \n-Credits (credits)");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "new":
                    Console.Clear();
                    RunGame();
                    break;
                case "load":
                    //add load from SQL
                    break;
                case "rules":
                    Console.Clear();
                    ReadRules();
                    break;
                case "credits":
                    Console.Clear();
                    ReadCredits();
                    break;
                default:
                    Console.WriteLine("Please choose 'new','load','rules', or 'credits'");
                    Console.ReadLine();
                    Console.Clear();
                    RunMenu();
                    break;
            }
        }
        private void RunGame()
        {
            Player player1 = new Player();
            player1.MakePlayerName();
            for (int i = 0; i <= 6; i++)
            {
                round = new Day(player1);
                round.GetTodaysWeather();
                round.GetInventory();
                round.GetRecipe();
                round.CalculateSales();
                round.DisplayTodaysSales();
                totalNetSales += round.dailyNetSales;
            }
            EndGame();
        }
        private void ReadRules()
        {
            string selection;
            Console.WriteLine("This is Lemonade Stand. You own a lemonade stand and will try to get as much profit as you can in 7 days. You will start with $50 and buy supplies, make lemonade, and set prices to try and make a profit. you will first: \n-Buy your ingrediants for the day (you keep unused ingrediants from the day before) \n-Set your recipe (be sure to look at the weather!) \n-Sell all day! \n-Repeat for 7 days \nAt the end of 7 day, your net sales are your score! to start type 'new' or 'back' to go to the main menu.");
            selection = Console.ReadLine();
            if (selection == "new")
            {
                Console.Clear();
                RunGame();
            }
            else if (selection == "back")
            {
                Console.Clear();
                RunMenu();
            }
            else
            {
                Console.WriteLine("Invalid choice! chose 'new' or 'back'");
                Console.Clear();
                ReadRules();
            }
        }
        private void ReadCredits()
        {
            Console.WriteLine("This game was designed and developed by: ANDREW JORDAN \nHit enter to go back");
            Console.ReadLine();
            Console.Clear();
            RunMenu();
        }
        private void EndGame()
        {
            Console.WriteLine("after a week of sales you close up the lemonade stand.");
            Console.WriteLine("Your total sales were: $" + totalNetSales + "\n Your net profit is: $" + GetProfit());
            Console.ReadLine();
        }
        private double GetProfit()
        {
             profit = (totalNetSales - 50);
            return profit; 
        }
    }
}
