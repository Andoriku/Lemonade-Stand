using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string playerName;

        public string MakePlayerName()
        {
            Console.WriteLine("What is your name? Enter name below");
            playerName = Console.ReadLine();
            return playerName;
        }
    }
}
