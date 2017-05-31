using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string currentWeather;

        public Weather()
        {
            GetCurrentWeather();
        }
        public string GetCurrentWeather()
        {
            Random random = new Random();
            int weather = random.Next(1, 6);
            switch (weather)
            {
                case 1:
                    currentWeather = "stormy but warm";
                    Console.WriteLine("todays weather is " + currentWeather + "!");
                    return currentWeather;
                case 2:
                    currentWeather = "stormy and cold";
                    Console.WriteLine("todays weather is " + currentWeather + "!");
                    return currentWeather;
                case 3:
                    currentWeather = "cloudy and cold";
                    Console.WriteLine("todays weather is " + currentWeather + "!");

                    return currentWeather;
                case 4:
                    currentWeather = "cloudy and warm";
                    Console.WriteLine("todays weather is " + currentWeather + "!");
                    return currentWeather;
                case 5:
                    currentWeather = "sunny and cool";
                    Console.WriteLine("todays weather is " + currentWeather + "!");

                    return currentWeather;
                case 6:
                    currentWeather = "sunny and hot";
                    Console.WriteLine("todays weather is " + currentWeather + "!");

                    return currentWeather;
                default:
                    currentWeather = "sunny and hot";
                    Console.WriteLine("todays weather is " + currentWeather + "!");

                        return currentWeather;
            }
        }
       
    }
}
