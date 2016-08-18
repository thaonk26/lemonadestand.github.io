using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStand
{
    class ReadFile
    {
        public ReadFile(Inventory inventory, Weather weather, Player player, Store store, Day day)
        {
            StreamReader readGame = new StreamReader(".\\GameSave.txt");
            saveGame.WriteLine("Player money, name, total sales and total money spent so far");
            saveGame.WriteLine(player.money);
            saveGame.WriteLine(player.name);
            saveGame.WriteLine(player.totalSales);
            saveGame.WriteLine(player.totalSpent);
            saveGame.WriteLine("Inventory: Lemons, Cups, Sugar");
            saveGame.WriteLine(inventory.lemon);
            saveGame.WriteLine(inventory.cups);
            readGame.WriteLine(inventory.sugar);
            readGame.WriteLine("Current weather and temperature");
            readGame.WriteLine(weather.currentWeather);
            readGame.WriteLine(weather.currentTemperature);
            readGame.WriteLine("Set days and current day");
            readGame.WriteLine(day.numberOfDays);
            readGame.WriteLine(day.currentDay);
            readGame.
            readGame.Close();

        }
    }
}
