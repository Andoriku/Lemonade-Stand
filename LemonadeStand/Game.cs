using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {

        public void menu()
        {
            Console.WriteLine("Welcome to Lemonade Stand. What would you like to do? \n-Start New Game (new) \n-Load Game (load) \n-Rules (rules) \n-Credits (credits)");
            string selection = Console.ReadLine();
            switch(selection)
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
                    menu();
                    break;
            }
        }
        public void RunGame()

        {
            TotalInventory totalInventory = new TotalInventory();
            Player player1 = new Player();
            player1.MakePlayerName();
            //loop for each round
            Day round = new Day();
            round.GetTodaysWeather();
            round.GetInventory();
            round.GetRecipe();
            round.MakeNewPitcher();
            round.GetTodaysCustomers(); 
        }
        private void ReadRules()
        {
           string selection;
            Console.WriteLine("This is Lemonade Stand. You own a lemonade stand and will try to get as much profit as you can in 7 days. You will start with $40 and buy supplies, make lemonade, and set prices to try and make a profit. you will first: \n-Buy your ingrediants for the day (you keep unused ingrediants from the day before) \n-Set your recipe (be sure to look at the weather!) \n-Sell all day! \n-Repeat for 7 days \nAt the end of 7 day, your net sales are your score! to start type 'new' or 'back' to go to the main menu.");
            selection = Console.ReadLine();
            if (selection == "new")
            {
                Console.Clear();
                RunGame();
            }
            else if (selection == "back")
            {
                Console.Clear();
                menu();
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
            menu();
        }
    }
}
