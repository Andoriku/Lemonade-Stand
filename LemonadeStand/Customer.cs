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
            if (customerProfile == 1)
            {
                Random randomPrice = new Random();
                customerLemonPreference = 2;
                customerSugarPreference = 1;
                customerPricePreference = Math.Round(getRandomDouble(.50,3.50),2);
            }
            else if (customerProfile == 2)
            {
                customerLemonPreference = 2;
                customerSugarPreference = 2;
                customerPricePreference = Math.Round(getRandomDouble(.50, 3.50), 2);
            }
            else if (customerProfile == 3)
            {
                customerLemonPreference = 3;
                customerSugarPreference = 2;
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
