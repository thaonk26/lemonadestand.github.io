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
                while (buyingLemons)
                {
                    Console.Clear();
                    Console.WriteLine("Would you like to buy 10($1), 20($2) or 40($4) Lemons? Enter '0' to exit.");
                    int amountOfLemons = Convert.ToInt32(Console.ReadLine());
                    switch (amountOfLemons)
                    {
                        case 10:
                            if ((totalMoney - (pricePerLemon * amountOfLemons) > 0))
                            {
                            lemon = lemon + amountOfLemons;
                            totalMoney = totalMoney - (pricePerLemon * amountOfLemons);
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
        public int BuyCups(double totalMoney)
        {
            bool buyingCups = true;
            while (buyingCups)
            {
                Console.Clear();
                Console.WriteLine("Would you like to buy 20($0.75), 40($1.50) or 100($3.75) Cups? Enter '0' to exit.");
                int amountOfCups = Convert.ToInt32(Console.ReadLine());
                switch (amountOfCups)
                {
                    case 20:
                        if ((totalMoney - (pricePerCup * amountOfCups) > 0))
                        {
                            cups = cups + amountOfCups;
                            totalMoney = totalMoney - (pricePerCup * amountOfCups);
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
        public int BuyIce(double totalMoney)
        {
            bool buyingIce = true;
            while (buyingIce)
            {
                Console.Clear();
                Console.WriteLine("Would you like to buy 100($0.80), 200($1.60) or 500($4) Ice? Enter '0' to exit.");
                int amountOfIce = Convert.ToInt32(Console.ReadLine());
                switch (amountOfIce)
                {
                    case 100:
                        if ((totalMoney - (pricePerIce * amountOfIce) > 0))
                        {
                            ice = ice + amountOfIce;
                            totalMoney = totalMoney - (pricePerIce * amountOfIce);
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
        public int BuySugar(double totalMoney)
        {
            bool buyingSugar = true;
            while (buyingSugar)
            {
                Console.Clear();
                Console.WriteLine("Would you like to buy 10($1), 20($2) or 40($4) Sugar? Enter '0' to exit.");
                int amountOfSugar = Convert.ToInt32(Console.ReadLine());
                switch (amountOfSugar)
                {
                    case 10:
                        if ((totalMoney - (pricePerSugar * amountOfSugar) > 0))
                        {
                            sugar = sugar + amountOfSugar;
                            totalMoney = totalMoney - (pricePerSugar * amountOfSugar);
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
