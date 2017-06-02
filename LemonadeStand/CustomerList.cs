using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CustomerList
    {
        List<Customer> todaysCustomers;
        Customer newCustomer;
        public CustomerList()
        {
            todaysCustomers = new List<Customer>();
            newCustomer = new Customer();
        }
        public List<Customer> GetCustomerList(Weather todaysWeather)
        {   
            switch (todaysWeather.currentWeather)
            {
                case "stormy but warm":
                    for (Int32 i = 0; i < 150;)
                    {
                        newCustomer = new Customer();
                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "stormy and cold":
                    for (Int32 i = 0; i < 100;)
                    {

                        newCustomer = new Customer();
                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "cloudy and cold":
                    for (Int32 i = 0; i < 200;)
                    {

                        newCustomer = new Customer();
                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "cloudy and warm":
                    for (Int32 i = 0; i < 250;)
                    {

                        newCustomer = new Customer();
                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "sunny and cool":
                    for (Int32 i = 0; i < 300;)
                    {

                        newCustomer = new Customer();
                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                case "sunny and warm":
                    for (Int32 i = 0; i < 350;)
                    {
                        newCustomer = new Customer();
                        todaysCustomers.Add(newCustomer);
                        i++;
                    }
                    Console.WriteLine(todaysCustomers.Count);
                    Console.ReadLine();
                    break;
                default:
                    for (Int32 i = 0; i < 250;)
                    {
                        newCustomer = new Customer();
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
