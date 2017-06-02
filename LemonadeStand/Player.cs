using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public TotalInventory totalInventory = new TotalInventory();
        public string playerName;

        public string MakePlayerName()
        {
            Console.WriteLine("What is your name? Enter name below");
            playerName = Console.ReadLine();
            Console.Clear();
            return playerName;
        }
    }
}
