using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public int lemon = 0;
        public int ice = 0;
        public int cups = 0;
        public int sugar = 0;
        public double pricePerLemon = .10;
        public double pricePerIce = .008;
        public double pricePerCup = 0.0375;
        public double pricePerSugar = .10;
        public Store()
        {            
        }
        public void printDisplay(Weather currentWeather, Weather tomorrowsWeather, Player player1, Inventory inventory, Day day)
        {
            Console.Clear();
            Console.WriteLine("{0}'s Lemonade Stand     ${1:000.00}     Today: {2} {3}*F   Tomorrow: {4} {5}*F", player1.name, player1.money, currentWeather.currentWeather, currentWeather.currentTemperature, tomorrowsWeather.currentWeather, tomorrowsWeather.currentTemperature);
            Console.WriteLine("{0}'s Inventory     {1} Lemons   {2} Sugar   {3} Ice   {4} Cups  Day {5} of {6}", player1.name, inventory.lemon, inventory.sugar, inventory.ice, inventory.cups, day.currentDay + 1, day.numberOfDays);
        }
        public int BuyLemons(double totalMoney, Weather currentWeather, Weather tomorrowsWeather, Player player1, Inventory inventory, Day day)
        {            
            bool buyingLemons = true;
            int amountOfLemons;
                while (buyingLemons)
                {
                    Console.Clear();
                    printDisplay(currentWeather, tomorrowsWeather, player1, inventory, day);
                    Console.WriteLine();
                    Console.WriteLine("Would you like to buy 10($1), 20($2) or 40($4) Lemons? Enter to move on.");
                    int.TryParse(Console.ReadLine(), out amountOfLemons);
                    switch (amountOfLemons)
                    {
                        case 10:
                            if ((totalMoney - (pricePerLemon * amountOfLemons) > 0))
                            {
                            lemon = lemon + amountOfLemons;
                            totalMoney = totalMoney - (pricePerLemon * amountOfLemons);
                            inventory.lemon = inventory.lemon + lemon;
                            player1.money = (player1.money - (lemon * pricePerLemon));
                        }
                            else
                            {
                                Console.WriteLine("You don't have enough money");
                                Console.ReadLine();
                            }
                            break;
                        case 20:
                            if ((totalMoney - (pricePerLemon * amountOfLemons) > 0))
                            {
                            lemon = lemon + amountOfLemons;
                            totalMoney = totalMoney - (pricePerLemon * amountOfLemons);
                            inventory.lemon = inventory.lemon + lemon;
                            player1.money = (player1.money - (lemon * pricePerLemon));
                        }
                            else
                            {
                                Console.WriteLine("You don't have enough money");
                                Console.ReadLine();
                            }
                            break;
                        case 40:
                        if ((totalMoney - (pricePerLemon * amountOfLemons) > 0))
                            {
                            lemon = lemon + amountOfLemons;
                            totalMoney = totalMoney - (pricePerLemon * amountOfLemons);
                            inventory.lemon = inventory.lemon + lemon;
                            player1.money = (player1.money - (lemon * pricePerLemon));
                        }
                        else
                            {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                            }
                            break;
                        default:
                            buyingLemons = false;
                            break;
                    }
                }
                return lemon;
        }
        public int BuyCups(double totalMoney, Weather currentWeather, Weather tomorrowsWeather, Player player1, Inventory inventory, Day day)
        {
            bool buyingCups = true;
            int amountOfCups;
            while (buyingCups)
            {
                Console.Clear();
                printDisplay(currentWeather, tomorrowsWeather, player1, inventory, day);
                Console.WriteLine();
                Console.WriteLine("Would you like to buy 20($0.75), 40($1.50) or 100($3.75) Cups? Enter to move on.");
                int.TryParse(Console.ReadLine(), out amountOfCups);
                switch (amountOfCups)
                {
                    case 20:
                        if ((totalMoney - (pricePerCup * amountOfCups) > 0))
                        {
                            cups = cups + amountOfCups;
                            totalMoney = totalMoney - (pricePerCup * amountOfCups);
                            inventory.cups = inventory.cups + cups;
                            player1.money = (player1.money - (cups * pricePerCup));
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 40:
                        if ((totalMoney - (pricePerCup * amountOfCups) > 0))
                        {
                            cups = cups + amountOfCups;
                            totalMoney = totalMoney - (pricePerCup * amountOfCups);
                            inventory.cups = inventory.cups + cups;
                            player1.money = (player1.money - (cups * pricePerCup));
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 100:
                        if ((totalMoney - (pricePerCup * amountOfCups) > 0))
                        {
                            cups = cups + amountOfCups;
                            totalMoney = totalMoney - (pricePerCup * amountOfCups);
                            inventory.cups = inventory.cups + cups;
                            player1.money = (player1.money - (cups * pricePerCup));
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        buyingCups = false;
                        break;
                }
            }
            return cups;
        }
        public int BuyIce(double totalMoney, Weather currentWeather, Weather tomorrowsWeather, Player player1, Inventory inventory, Day day)
        {
            bool buyingIce = true;
            int amountOfIce;
            while (buyingIce)
            {
                Console.Clear();
                printDisplay(currentWeather, tomorrowsWeather, player1, inventory, day);
                Console.WriteLine();
                Console.WriteLine("Would you like to buy 100($0.80), 200($1.60) or 500($4) Ice? Enter to move on.");
                int.TryParse(Console.ReadLine(), out amountOfIce);
                switch (amountOfIce)
                {
                    case 100:
                        if ((totalMoney - (pricePerIce * amountOfIce) > 0))
                        {
                            ice = ice + amountOfIce;
                            totalMoney = totalMoney - (pricePerIce * amountOfIce);
                            inventory.ice = inventory.ice + ice;
                            player1.money = player1.money - (ice * pricePerIce);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;

                    case 200:
                        if ((totalMoney - (pricePerIce * amountOfIce) > 0))
                        {
                            ice = ice + amountOfIce;
                            totalMoney = totalMoney - (pricePerIce * amountOfIce);
                            inventory.ice = inventory.ice + ice;
                            player1.money = player1.money - (ice * pricePerIce);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 500:
                        if ((totalMoney - (pricePerIce * amountOfIce) > 0))
                        {
                            ice = ice + amountOfIce;
                            totalMoney = totalMoney - (pricePerIce * amountOfIce);
                            inventory.ice = inventory.ice + ice;
                            player1.money = player1.money - (ice * pricePerIce);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        buyingIce = false;
                        break;
                }
            }
            return ice;
        }
        public int BuySugar(double totalMoney, Weather currentWeather, Weather tomorrowsWeather, Player player1, Inventory inventory, Day day)
        {
            bool buyingSugar = true;
            int amountOfSugar;
            while (buyingSugar)
            {
                Console.Clear();
                printDisplay(currentWeather, tomorrowsWeather, player1, inventory, day);
                Console.WriteLine();
                Console.WriteLine("Would you like to buy 10($1), 20($2) or 40($4) Sugar? Enter to move on.");
                int.TryParse(Console.ReadLine(), out amountOfSugar);
                switch (amountOfSugar)
                {
                    case 10:
                        if ((totalMoney - (pricePerSugar * amountOfSugar) > 0))
                        {
                            sugar = sugar + amountOfSugar;
                            totalMoney = totalMoney - (pricePerSugar * amountOfSugar);
                            inventory.sugar = inventory.sugar + sugar;
                            player1.money = player1.money - (sugar * pricePerSugar);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 20:
                        if ((totalMoney - (pricePerSugar * amountOfSugar) > 0))
                        {
                            sugar = sugar + amountOfSugar;
                            totalMoney = totalMoney - (pricePerSugar * amountOfSugar);
                            inventory.sugar = inventory.sugar + sugar;
                            player1.money = player1.money - (sugar * pricePerSugar);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case 40:
                        if ((totalMoney - (pricePerSugar * amountOfSugar) > 0))
                        {
                            sugar = sugar + amountOfSugar;
                            totalMoney = totalMoney - (pricePerSugar * amountOfSugar);
                            inventory.sugar = inventory.sugar + sugar;
                            player1.money = player1.money - (sugar * pricePerSugar);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        buyingSugar = false;
                        break;
                }
            }
            return sugar;
        }
    }
}
