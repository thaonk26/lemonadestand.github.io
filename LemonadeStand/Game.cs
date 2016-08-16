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
        Store store = new Store();
        Inventory inventory = new Inventory();
        Customer[] customer = new Customer[100];
        Weather weather = new Weather();
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
                SpawnCustomer();
                SetWeather();
                PrepLemonade();
                SetRecipe();
                SetPitcher();
                RunDay();
            }
        }
        public void PrepLemonade()
        {
            inventory.CurrentInventory();
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            int lemon = store.BuyLemons(player1.money);
            inventory.lemon = inventory.lemon + lemon;
            player1.money = (player1.money - (lemon * 0.15));
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            int cups = store.BuyCups(player1.money);
            inventory.cups = inventory.cups + cups;
            player1.money = (player1.money - (cups * 0.0375));
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            int ice = store.BuyIce(player1.money);
            inventory.ice = inventory.ice + ice;
            player1.money = player1.money - (ice * 0.008);
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            int sugar = store.BuySugar(player1.money);
            inventory.sugar = inventory.sugar + sugar;
            player1.money = player1.money - (sugar * 0.15);
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            inventory.CurrentInventory();
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.Clear();
            Console.WriteLine("At what would you like to sell your Lemonade at?");
            player1.lemonadePrice = (Convert.ToDouble(Console.ReadLine()));
        }
        public void SetWeather()
        {
            Console.WriteLine("Weather is set to {0} at {1} degrees", weather.currentWeather, weather.currentTemperature);
        }
        
        public void SpawnCustomer()
        {
            for (int i = 0; i < customer.Length; i++)
            {
                customer[i] = new Customer();

            }

        }
        public void SetRecipe()
        {
            player1.SetRecipe();
        }
        public void SetPitcher()
        {
            if((inventory.lemon - player1.lemonRecipe > 0) && (inventory.sugar - player1.sugarRecipe > 0) && (inventory.cups - 12) > 0)
            {
                inventory.pitcher = 12;
                inventory.lemon = inventory.lemon - player1.lemonRecipe;
                inventory.sugar = inventory.sugar - player1.sugarRecipe;
                inventory.cups = inventory.cups - 12;
            } else
            {
                inventory.pitcher = 0;
                Console.WriteLine("SOLD OUT");
            }

        }
        public void RunDay()
        {
            bool customersBuy = true;
            while (customersBuy)
            {
                for (int i = 0; i < customer.Length; i++)
                {
                    customer[i].CustomerBuyChance(inventory, weather, player1);
                    if (inventory.pitcher > 0)
                    {
                        inventory.pitcher--;
                        inventory.ice = inventory.ice - player1.iceRecipe;
                        player1.money = player1.money + player1.lemonadePrice;
                        Console.WriteLine("Customer {0} bought a cup!", i + 1);
                    }
                    else
                    {
                        
                        if ((inventory.lemon - player1.lemonRecipe > 0) && (inventory.sugar - player1.sugarRecipe > 0) && (inventory.cups - 12) > 0)
                        {
                            SetPitcher();
                        }
                        else
                        {
                            Console.WriteLine("Customer {0} passed by", i + 1);
                            customersBuy = false;
                        }
                    }
                    i++;
                }
            }
        }
    }
}
