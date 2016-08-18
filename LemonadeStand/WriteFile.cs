using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStand
{
    class WriteFile
    {
        public WriteFile(Inventory inventory, Weather weather, Player player, Store store, Day day)
        {
            TextWriter saveGame = new StreamWriter(".\\GameSave.txt");
            saveGame.WriteLine("Player money, name, total sales and total money spent so far");
            saveGame.WriteLine(player.money);
            saveGame.WriteLine(player.name);
            saveGame.WriteLine(player.totalSales);
            saveGame.WriteLine(player.totalSpent);
            saveGame.WriteLine("Inventory: Lemons, Cups, Sugar");
            saveGame.WriteLine(inventory.lemon);
            saveGame.WriteLine(inventory.cups);
            saveGame.WriteLine(inventory.sugar);
            saveGame.WriteLine("Current weather and temperature");
            saveGame.WriteLine(weather.currentWeather);
            saveGame.WriteLine(weather.currentTemperature);
            saveGame.WriteLine("Set days and current day");
            saveGame.WriteLine(day.numberOfDays);
            saveGame.WriteLine(day.currentDay);

            saveGame.Close();
            Environment.Exit(0);
        }
    }
}
