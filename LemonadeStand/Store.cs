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
        public double lemonadePrice;
        public int sugar;
        public Store()
        {

        }
        //public void BuyIngredients(Inventory inventory)
        //{
        //    bool buyIngredients = true;
        //    while (buyIngredients)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Welcome to the store, what would you like to buy?\n lemons, cups, sugar or ice? Enter '0' to exit.");
        //    string buyingIngredients = Console.ReadLine();
        //        {
        //            switch (buyingIngredients)
        //            {
        //                case "lemons":
        //                    Console.WriteLine("How many would you like?");
        //                    BuyLemons();
        //                    Console.WriteLine("You have bought {0} Lemons", lemon);
        //                    break;
        //                case "cups":
        //                    Console.WriteLine("How many would you like?");
        //                    BuyCups();
        //                    Console.WriteLine("You have bought {0} Cups", cups);
        //                    break;
        //                case "ice":
        //                    Console.WriteLine("How many would you like?");
        //                    BuyIce();
        //                    break;
        //                case "sugar":
        //                    Console.WriteLine("How many would you like?");
        //                    BuySugar();
        //                    break;
        //                default:
        //                    buyIngredients = false;
        //                    break;
        //            }
        //        }    
        //    }
        //}
        public int BuyLemons(double totalMoney)
        {
            bool buyingLemons = true;
            lemon = 0;
            while (buyingLemons)
            {
                Console.Clear();
                Console.WriteLine("Would you like to buy 10($1.50), 20($3) or 40($6) Lemons? Enter '0' to exit.");
                int amountOfLemons = Convert.ToInt32(Console.ReadLine());
                switch (amountOfLemons)
                {
                    case 10:

                        if (totalMoney > 0)
                        {
                            lemon = lemon + 10;
                        }else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    case 20:
                        if (totalMoney > 0)
                        {
                            lemon = lemon + 20;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    case 40:
                        if (totalMoney > 0)
                        {
                            lemon = lemon + 40;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    default:
                        buyingLemons = false;
                        break;
                }
            }
            return lemon;
        }
        public int BuyCups(double totalMoney)
        {
            bool buyingCups = true;
            int cups = 0;
            while (buyingCups)
            {
                Console.Clear();
                Console.WriteLine("Would you like to buy 20($0.75), 40($1.50) or 100($3.75) Cups? Enter '0' to exit.");
                int amountOfCups = Convert.ToInt32(Console.ReadLine());
                switch (amountOfCups)
                {
                    case 20:
                        if (totalMoney > 0)
                        {
                            cups = cups + 20;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    case 40:
                        if (totalMoney > 0)
                        {
                            cups = cups + 40;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    case 100:
                        if (totalMoney > 0)
                        {
                            cups = cups + 100;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    default:
                        buyingCups = false;
                        break;
                }
            }
            return cups;
        }
        public int BuyIce(double totalMoney)
        {
            bool buyingIce = true;
            int ice = 0;
            while (buyingIce)
            {
                Console.Clear();
                Console.WriteLine("Would you like to buy 100($0.80), 200($1.60) or 500($4) Ice? Enter '0' to exit.");
                int amountOfIce = Convert.ToInt32(Console.ReadLine());
                switch (amountOfIce)
                {
                    case 100:
                        if (totalMoney > 0)
                        {
                            ice = ice + 100;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;

                    case 200:
                        if (totalMoney > 0)
                        {
                            ice = ice + 200;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    case 500:
                        if (totalMoney > 0)
                        {
                            ice = ice + 500;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    default:
                        buyingIce = false;
                        break;
                }
            }
            return ice;
        }
        public int BuySugar(double totalMoney)
        {
            bool buyingSugar = true;
            int sugar = 0;
            while (buyingSugar)
            {
                Console.Clear();
                Console.WriteLine("Would you like to buy 10($1.50), 20($3) or 40($6) Sugars? Enter '0' to exit.");
                int amountOfSugar = Convert.ToInt32(Console.ReadLine());
                switch (amountOfSugar)
                {
                    case 10:
                        if (totalMoney > 0)
                        {
                            sugar = sugar + 10;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    case 20:
                        if (totalMoney > 0)
                        {
                            sugar = sugar + 20;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                        }
                        break;
                    case 40:
                        if (totalMoney > 0)
                        {
                            sugar = sugar + 40;
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
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
