using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CustomerList
    {

        public List<Customer> GetCustomerList(Weather todaysWeather)
        {
            List<Customer> todaysCustomers = new List<Customer>();

            switch (todaysWeather.currentWeather)
            {
                case "stormy but warm":
                    for (Int32 i = 0; i < 150;)
                    {
                        Customer newCustomer = new Customer();

                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "stormy and cold":
                    for (Int32 i = 0; i < 100;)
                    {
                        Customer newCustomer = new Customer();

                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "cloudy and cold":
                    for (Int32 i = 0; i < 200;)
                    {
                        Customer newCustomer = new Customer();

                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "cloudy and warm":
                    for (Int32 i = 0; i < 250;)
                    {
                        Customer newCustomer = new Customer();

                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "sunny and cool":
                    for (Int32 i = 0; i < 300;)
                    {
                        Customer newCustomer = new Customer();

                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "sunny and warm":
                    for (Int32 i = 0; i < 350;)
                    {
                        Customer newCustomer = new Customer();

                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                default:
                    for (Int32 i = 0; i < 250;)
                    {
                        Customer newCustomer = new Customer();

                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
            }
            return todaysCustomers;
    }
    }
}
