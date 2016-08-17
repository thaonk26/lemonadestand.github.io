using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace LemonadeStand
{
    class Game
    {
        Player player1;
        Inventory inventory = new Inventory();
        Customer[] customer = new Customer[100];
        Weather weather = new Weather();
        SoundPlayer sound = new SoundPlayer("http://themushroomkingdom.net/sounds/wav/smw/smw_stomp.wav");
        int days;
        public Game()
        {
            Console.WriteLine("What is your name?");
            player1 = new Player(Console.ReadLine());
        }
        public void RunGame()
        {
            Console.WriteLine("How many days would you like to work at\n the Lemonade stand for? (minimum 7 days)");
            days = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < days; i++)
            {
                Console.Clear();
                Console.WriteLine("Day {1} of {0}", days, i + 1);
                SpawnCustomer();
                SetWeather();
                PrepLemonade();
                SetRecipe();
                SetPitcher();
                RunDay();
                Console.ReadLine();
            }
        }
        public void PrepLemonade()
        {
            Store store = new Store();
            inventory.CurrentInventory();
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            int lemon = store.BuyLemons(player1.money);
            inventory.lemon = inventory.lemon + lemon;
            player1.money = (player1.money - (store.lemon * store.pricePerLemon));
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            int cups = store.BuyCups(player1.money);
            inventory.cups = inventory.cups + cups;
            player1.money = (player1.money - (store.cups * store.pricePerCup));
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            int ice = store.BuyIce(player1.money);
            inventory.ice = inventory.ice + ice;
            player1.money = player1.money - (store.ice * store.pricePerIce);
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            int sugar = store.BuySugar(player1.money);
            inventory.sugar = inventory.sugar + sugar;
            player1.money = player1.money - (store.sugar * store.pricePerSugar);
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.ReadLine();
            inventory.CurrentInventory();
            Console.WriteLine("You currently have ${0} in your wallet.", player1.money);
            Console.Clear();
            Console.WriteLine("Predicted Weather for today is {0} at {1} degrees", weather.SetWeather(), weather.SetTemperature());
            weather.ChangeWeather();
            player1.totalSpent = player1.totalSpent + (store.lemon * store.pricePerLemon) + (store.sugar * store.pricePerSugar) + (store.ice * store.pricePerIce) + (store.cups * store.pricePerCup);
            Console.WriteLine("At what would you like to sell your Lemonade at?");
            player1.lemonadePrice = (Convert.ToDouble(Console.ReadLine()));
        }
        public void SetWeather()
        {
            Console.WriteLine("Predicted Weather for tomorrow is {0} at {1} degrees", weather.SetWeather(), weather.SetTemperature());
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
            }

        }
        public void RunDay()
        {
            bool customersBuy = true;
            while (customersBuy)
            {
                for (int i = 0; i < customer.Length; i++)
                {
                    if (player1.lemonadePrice < 1.5)
                    {
                        if ((inventory.lemon - player1.lemonRecipe > 0) && (inventory.sugar - player1.sugarRecipe > 0) && (inventory.cups - 12) > 0)
                        {
                            if (customer[i].CustomerBuyChance(inventory, weather, player1) != false)
                            {
                                if (inventory.pitcher > 0 && inventory.ice > 0)
                                {
                                    inventory.pitcher--;
                                    inventory.ice = inventory.ice - player1.iceRecipe;
                                    player1.money = player1.money + player1.lemonadePrice;
                                    Console.WriteLine("Customer {0} bought a cup!", i + 1);
                                    sound.Play();
                                    player1.totalSales = player1.totalSales + player1.lemonadePrice;
                                    player1.dailySales = player1.dailySales + player1.lemonadePrice;
                                }
                                else
                                {

                                    if ((inventory.lemon - player1.lemonRecipe > 0) && (inventory.sugar - player1.sugarRecipe > 0) && (inventory.cups - 12) > 0)
                                    {
                                        SetPitcher();
                                    }
                                    else
                                    {
                                        Console.WriteLine("SOLD OUT");
                                        customersBuy = false;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Customer {0} passed by", i + 1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("SOLD OUT");
                        }
                    } else
                    {
                        Console.WriteLine("Too expensive!!");
                    }
                }
                customersBuy = false;
            }
            Console.WriteLine("All your ice has melted!");
            inventory.ice = 0;
        }
        public void TotalSalesResults()
        {
            Store store = new Store();
            Console.Clear();
            Console.WriteLine("Your total sales for {1} Days are ${0}", player1.totalSales, days);
            Console.WriteLine("Your total money spent during the {0} Days are ${1}", days, player1.totalSpent);
            inventory.liquidatedInventory = (inventory.ice * store.pricePerIce) + (inventory.lemon * store.pricePerLemon) + (inventory.sugar * store.pricePerSugar) + (inventory.cups * store.pricePerCup);
            Console.WriteLine("Your liquidated inventory value is ${0}", inventory.liquidatedInventory);
            double profits = player1.totalSales - player1.totalSpent - inventory.liquidatedInventory;
            if(profits > 0)
            {
                Console.WriteLine("You have made a profit of ${0}", profits);
            } else
            {
                Console.WriteLine("You didn't make a profit and lost ${0}", profits);
            }
            Console.ReadLine();
        }
    }
}
