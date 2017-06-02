using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
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
                    return currentWeather;
                case 2:
                    currentWeather = "stormy and cold";
                    return currentWeather;
                case 3:
                    currentWeather = "cloudy and cold";
                    return currentWeather;
                case 4:
                    currentWeather = "cloudy and warm";
                    return currentWeather;
                case 5:
                    currentWeather = "sunny and cool";
                    return currentWeather;
                case 6:
                    currentWeather = "sunny and hot";
                    return currentWeather;
                default:
                    currentWeather = "sunny and hot";
                    return currentWeather;
            }
        }
        public void DipslayCurrentWeather(string currentWeather)
        {
            Console.WriteLine("You look outside the window and see today's weather is " + currentWeather + "!");
            Console.ReadLine();
        }

    }
}
