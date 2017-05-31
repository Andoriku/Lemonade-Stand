using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CustomerList
    {
        Weather todaysWeather = new Weather();
        Customer newCustomer = new Customer();

        public List<int> GetCustomerList()
        {
            List<int> todaysCustomers = new List<int>();

            switch (todaysWeather.currentWeather)
            {
                case "stormy but warm":
                    for (Int32 i = 0; i < 150;)
                    {
                        todaysCustomers.Add(newCustomer.customerType());
                        i++;
                    }
                    break;
                case "stormy and cold":
                    for (Int32 i = 0; i < 100;)
                    {
                        todaysCustomers.Add(newCustomer.customerType());
                        i++;
                    }
                    break;
                case "cloudy and cold":
                    for (Int32 i = 0; i < 200;)
                    {
                        todaysCustomers.Add(newCustomer.customerType());
                        i++;
                    }
                    break;
                case "cloudy and warm":
                    for (Int32 i = 0; i < 250;)
                    {
                        todaysCustomers.Add(newCustomer.customerType());
                        i++;
                    }
                    break;
                case "sunny and cool":
                    for (Int32 i = 0; i < 300;)
                    {
                        todaysCustomers.Add(newCustomer.customerType());
                        i++;
                    }
                    break;
                case "sunny and warm":
                    for (Int32 i = 0; i < 350;)
                    {
                        todaysCustomers.Add(newCustomer.customerType());
                        i++;
                    }
                    break;
                default:
                    for (Int32 i = 0; i < 250;)
                    {
                        todaysCustomers.Add(newCustomer.customerType());
                        i++;
                    }
                    break;
            }
            return todaysCustomers;
    }
    }
}
