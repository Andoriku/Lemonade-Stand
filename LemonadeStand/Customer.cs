using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        private int customerProfile;
        public int  customerLemonPreference;
        public int customerSugarPreference;
        public Customer()
            {
            customerType();
            DefineCustomerPref(customerProfile);
            }

        public void DefineCustomerPref(int customerProfile)
        {
            if (customerProfile == 1)
            {
                customerLemonPreference = 2;
                customerSugarPreference = 1;
            }
            else if (customerProfile == 2)
            {
                customerLemonPreference = 3;

            }
        }
        public void customerType()
        {
            Random random = new Random();
            int customer = random.Next(1, 3);
            switch (customer)
            {
                case 1:
                    customerProfile = 1;
                    break;
                case 2:
                    customerProfile = 2;
                    break;
                case 3:
                    customerProfile = 3;
                    break;
                default:
                    customerProfile = 1;
                    break;
            }
        }
        
    }
}
