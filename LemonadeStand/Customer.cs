using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public Customer()
        {

        }
        public bool CustomerBuyChance(Inventory inventory, Weather weather, Player player)
        {
            Thread.Sleep((int)TimeSpan.FromSeconds(.3).TotalMilliseconds);
            Random random = new Random();
            if (weather.ChangeWeather() < 60 && player.lemonadePrice <= .20 && inventory.ice <= 4)
            {
                if (random.Next(1, 21) == 1) { return true; } else { return false; }
            }
            else if (weather.ChangeWeather() < 70 && player.lemonadePrice <= .25 && inventory.ice <= 6)
            {
                if (random.Next(1, 16) == 1) { return true; } else { return false; }
            }
            else if (weather.ChangeWeather() < 80 && player.lemonadePrice <= .30 && inventory.ice <= 8)
            {
                if (random.Next(1, 11) == 1) { return true; } else { return false; }
            }
            else if (weather.ChangeWeather() < 90 && player.lemonadePrice <= .40 && inventory.ice <= 10)
            {
                if (random.Next(1, 7) == 1) { return true; } else { return false; }
            }
            else if (weather.ChangeWeather() < 100 && player.lemonadePrice <= .50 && inventory.ice <= 10)
            {
                if (random.Next(1, 4) == 1) { return true; } else { return false; }
            }
            else {
                if (random.Next(1, 26) == 1) { return true; } else { return false; }
            }
        }
    }
}
