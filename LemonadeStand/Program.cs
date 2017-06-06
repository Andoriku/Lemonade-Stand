using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        private static void Main(string[] args)
        {
            Game NewGame = new LemonadeStand.Game();
            NewGame.RunMenu();
        }
    }
}
