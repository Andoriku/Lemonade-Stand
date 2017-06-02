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
        public List<int> PitcherList;


        PitcherCups pitcherList;

        public Pitcher(List<int> PitcherList)
        {
            pitcherList = new PitcherCups();
        }
        public void ChoseLemonAmount()
        {
            Console.WriteLine("how many lemons per pitcher for today? Enter a number.");
            numberOfLemons = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

        }
        public void ChoseCupsOfSugarAmount()
        {
            Console.WriteLine("how many cups of sugar per pitcher for today? Enter a number.");
            numberOfCupsOfSugar = Math.Round(Convert.ToDouble(Console.ReadLine()), 2); ;
        }
        public void ChoseNumberOfIceCubes()
        {
            Console.WriteLine("how many ice cubes per cup for today? Enter a number.");
            numberOfIceCubes = Convert.ToInt32(Console.ReadLine()) * 10;
        }
        public double GetCupPrice()
        {
            Console.WriteLine("How much would you like to sell each cup for?");
            double salePrice = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            Console.Clear();
            Console.WriteLine("Each cup of lemonade will be sold today for $" + salePrice + ".");
            return salePrice;
        }
        public void Pour10Cups()
        {
            PitcherList = pitcherList.Newlist();
        }
        public void GetPitcherCupCount()
        {
            pitcherList.Count();
        }

    }
}
