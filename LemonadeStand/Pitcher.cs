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


        CustomerCups pitcherCups = new CustomerCups();

        public void ChoseLemonAmount()
        {
            Console.WriteLine("how many lemons per pitcher for today? Enter a number.");
            numberOfLemons = Convert.ToInt32(Console.ReadLine());
            
        }
        public void ChoseCupsOfSugarAmount()
        {
            Console.WriteLine("how many cups of sugar per pitcher for today? Enter a number.");
            numberOfCupsOfSugar = Convert.ToInt32(Console.ReadLine());
        }
        public void ChoseNumberOfIceCubes()
        {
            Console.WriteLine("how many ice cubes per cup for today? Enter a number.");
            numberOfIceCubes = Convert.ToInt32(Console.ReadLine()) * 10;
        }
        public void Pour10Cups()
        {
          PitcherList = pitcherCups.Newlist();
        }
        public void SellOneCup()
        { 

            PitcherList.Remove(0);
        }

    }
}
