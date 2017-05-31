using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public int customerType()
        {
            Random random = new Random();
            int customer = random.Next(1, 3);
            switch (customer)
            {
                case 1:
                    return customer;
                case 2:
                    return customer;
                case 3:
                    return customer;
                default:
                    return customer;
            }
        }
    }
}
