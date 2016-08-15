using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player1;
        public Game()
        {
            Console.WriteLine("What is your name?");
            player1 = new Player(Console.ReadLine());
        }
        public void RunGame()
        {
            Console.WriteLine("How many days would you like to work at\n the Lemonade stand for? (minimum 7 days)");
            int days = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("Day {1} of {0}", days, i + 1);
                PrepLemonade();
                SetWeather();
            }
        }
        public void PrepLemonade()
        {
            Store store = new Store();
            Inventory inventory = new Inventory();
            store.BuyIngredients();
            Console.WriteLine("What would you like to sell your Lemonade at?");
            store.lemonade = (Convert.ToInt32(Console.ReadLine()));
        }
        public void SetWeather()
        {
            Weather weather = new Weather();
            weather.SetWeather();
        }
    }
}
