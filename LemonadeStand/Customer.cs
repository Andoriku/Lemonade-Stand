using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public int customerProfile;
        public int customerLemonPreference;
        public int customerSugarPreference;
        public double customerPricePreference;
        public Customer()
        {
            customerType();
            DefineCustomerPref(customerProfile);
        }

        public void DefineCustomerPref(int customerProfile)
        {
            Random random = new Random();
            if (customerProfile == 1)
            {
                customerLemonPreference = random.Next(1, 5);
                customerSugarPreference = random.Next(1, 5);
                customerPricePreference = Math.Round(getRandomDouble(.50,3.50),2);
            }
            else if (customerProfile == 2)
            {
                customerLemonPreference = random.Next(1,4);
                customerSugarPreference = random.Next(1, 4);
                customerPricePreference = Math.Round(getRandomDouble(.50, 3.50), 2);
            }
            else if (customerProfile == 3)
            {
                customerLemonPreference = random.Next(1, 6);
                customerSugarPreference = random.Next(1, 6);
                customerPricePreference = Math.Round(getRandomDouble(.50, 3.50), 2);
            }
        }
        public void customerType()
        {
            Random random = new Random();
            customerProfile = random.Next(1, 4);

        }
        public double getRandomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
    }

}
