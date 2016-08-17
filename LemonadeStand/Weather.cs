using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        Random random = new Random();
        public string currentWeather;
        public int currentTemperature;
        public Weather()
        {
        }
        public string SetWeather()
        {
            int weather = random.Next(1, 4);
            switch (weather)
            {
                case 1:
                    currentWeather = "Sunny";
                    break;
                case 2:
                    currentWeather = "Rainy";
                    break;
                default:
                    currentWeather = "Cloudy";
                    break;
            }
            return currentWeather;
        }
        public int SetTemperature()
        {
            currentTemperature = random.Next(50, 101);

            return currentTemperature;
        }
        public int ChangeWeather()
        {
            if(currentWeather == "Rainy")
            {
                currentTemperature = currentTemperature - 10;
                return currentTemperature;
            } else if(currentWeather == "Cloudy")
            {
                currentTemperature = currentTemperature - 5;
                return currentTemperature;
            }else { return currentTemperature; }
        }
    }
}
