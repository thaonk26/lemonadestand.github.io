using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public int lemon;
        public int ice;
        public int cups;
        public int lemonade;
        public int sugar;
        public Store()
        {

        }
        public void BuyIngredients()
        {

            Console.WriteLine("Welcome to the store, what would you like to buy?\n lemons, cups, sugar or ice?");
            string buyingIngredients = Console.ReadLine();

            {
                switch (buyingIngredients)
                {
                    case "lemons":
                        Console.WriteLine("How many would you like?");
                        BuyLemons();
                        Console.WriteLine("You have bought {0} Lemons", lemon);
                        break;
                    case "cups":
                        Console.WriteLine("How many would you like?");
                        BuyCups();
                        Console.WriteLine("You have bought {0} Cups", cups);
                        break;
                    case "ice":
                        Console.WriteLine("How many would you like?");
                        BuyIce();
                        break;
                    case "sugar":
                        Console.WriteLine("How many would you like?");
                        BuySugar();
                        break;
                    default:
                        break;
                }             
            }
        }
        public int BuyLemons()
        {
            bool buyingLemons = true;
            int lemon = 0;
            while (buyingLemons)
            {
                Console.WriteLine("Would you like to buy 10, 20 or 40 Lemons?");
                int amountOfLemons = Convert.ToInt32(Console.ReadLine());
                switch (amountOfLemons)
                {
                    case 10:
                        lemon = lemon + 10;
                        break;
                    case 20:
                        lemon = lemon + 20;
                        break;
                    case 40:
                        lemon = lemon + 40;
                        break;
                    default:
                        buyingLemons = false;
                        break;
                }
            }
            return lemon;
        }
        public double BuyCups()
        {
            bool buyingCups = true;
            int cups = 0;
            while (buyingCups)
            {
                Console.WriteLine("Would you like to buy 20, 40 or 100 Cups?");
                int amountOfCups = Convert.ToInt32(Console.ReadLine());
                switch (amountOfCups)
                {
                    case 20:
                        cups = cups + 20;
                        break;
                    case 40:
                        cups = cups + 40;
                        break;
                    case 100:
                        cups = cups + 100;
                        break;
                    default:
                        buyingCups = false;
                        break;
                }
            }
            return cups;
        }
        public double BuyIce()
        {
            bool buyingIce = true;
            int ice = 0;
            while (buyingIce)
            {
                Console.WriteLine("Would you like to buy 100, 200 or 500 Ice?");
                int amountOfIce = Convert.ToInt32(Console.ReadLine());
                switch (amountOfIce)
                {
                    case 100:
                        ice = ice + 100;
                        break;

                    case 200:
                        ice = ice + 200;
                        break;
                    case 500:
                        ice = ice + 500;
                        break;
                    default:
                        buyingIce = false;
                        break;
                }
            }
            return ice;
        }
        public double BuySugar()
        {
            bool buyingSugar = true;
            int sugar = 0;
            while (buyingSugar)
            {
                Console.WriteLine("Would you like to buy 10, 20 or 40 Sugars?");
                int amountOfSugar = Convert.ToInt32(Console.ReadLine());
                switch (amountOfSugar)
                {
                    case 10:
                        sugar = sugar + 10;
                        break;
                    case 20:
                        sugar = sugar + 20;
                        break;
                    case 40:
                        sugar = sugar + 40;
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
