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
            Thread.Sleep((int)TimeSpan.FromSeconds(.225).TotalMilliseconds);
            Random random = new Random();
            if (weather.currentTemperature < 60 && player.lemonadePrice <= .20 && player.iceRecipe <= 4)
            {
                if (random.Next(1, 8) == 5) { return true; } else { return false; }
            }
            else if (weather.currentTemperature < 70 && player.lemonadePrice <= .25 && player.iceRecipe <= 6)
            {
                if (random.Next(1, 8) == 4) { return true; } else { return false; }
            }
            else if (weather.currentTemperature < 80 && player.lemonadePrice <= .30 && player.iceRecipe <= 8)
            {
                if (random.Next(1, 5) == 3) { return true; } else { return false; }
            }
            else if (weather.currentTemperature < 90 && player.lemonadePrice <= .40 && player.iceRecipe <= 10)
            {
                if (random.Next(1, 4) == 3) { return true; } else { return false; }
            }
            else if (weather.currentTemperature < 100 && player.lemonadePrice <= .50 && player.iceRecipe <= 10)
            {
                if (random.Next(1, 2) == 1) { return true; } else { return false; }
            }
            else {
                if (random.Next(1, 12) == 1) { return true; } else { return false; }
            }
        }
    }
}
