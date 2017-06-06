using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        public double numberOfLemons;
        public double numberOfCupsOfSugar;
        public int numberOfIceCubes;
        public double salePrice;
        public List<int> pitcherCups = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



        public Pitcher()
        {

        }
        public void ChoseLemonAmount()
        {
            Console.WriteLine("how many lemons per pitcher for today? Enter a number.");
            try
            {
                numberOfLemons = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            }
            catch
            {
                Console.WriteLine("Oops! Looks Like you need to type a number for the amount");
                ChoseLemonAmount();
            }
            Console.WriteLine("Are you sure youd like to add " + numberOfLemons + "? 'y' or 'n'");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                ChoseLemonAmount();
            }
            else
            {
                Console.WriteLine("You add " + numberOfLemons + " lemons to the pitcher.");
            }
        }
        public void ChoseCupsOfSugarAmount()
        {
            Console.WriteLine("how many cups of sugar per pitcher for today? Enter a number.");
            try
            {
                numberOfCupsOfSugar = Math.Round(Convert.ToDouble(Console.ReadLine()), 2); ;

            }
            catch
            {
                Console.WriteLine("Oops! Looks Like you need to type a number for the amount");
                ChoseCupsOfSugarAmount();
            }
            Console.WriteLine("Are you sure youd like to add " + numberOfCupsOfSugar + "? 'y' or 'n'");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                ChoseCupsOfSugarAmount();
            }
            else
            {
                Console.WriteLine("You add " + numberOfCupsOfSugar + " cups of sugar to the pitcher.");
            }
        }
        public void ChoseNumberOfIceCubes()
        {
            Console.WriteLine("how many ice cubes per cup for today? Enter a number.");
            try
            {
                numberOfIceCubes = Convert.ToInt32(Console.ReadLine()) * 10;
            }
            catch
            {
                Console.WriteLine("Oops! Looks Like you need to type a number for the amount");
                ChoseNumberOfIceCubes();
            }
            Console.WriteLine("Are you sure youd like to add " + numberOfIceCubes + "? 'y' or 'n'");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                ChoseNumberOfIceCubes();
            }
            else
            {
                Console.WriteLine("You add " + numberOfIceCubes + " ice cubes to the pitcher.");
            }
        }
        public double GetCupPrice()
        {
            Console.WriteLine("How much would you like to sell each cup for?");
            try
            {
                salePrice = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            }
            catch
            {
                Console.WriteLine("Oops! You didn't type in a valid price, try again.");
                GetCupPrice();
            }
            Console.WriteLine("Each cup of lemonade will be sold today for $" + salePrice + ".");
            Console.ReadLine();
            Console.Clear();
            return salePrice;
        }

    }
}
