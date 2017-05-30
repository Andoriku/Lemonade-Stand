using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public void GetInventory()
        {
            Inventory Inventory = new Inventory();
            Inventory.GetNewCupInventory();
            Inventory.GetNewLemonInventory();
            Inventory.GetNewBudget();
        }
        
    }
}
