using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public double money;
        public int iceRecipe;
        public int sugarRecipe;
        public int lemonRecipe;
        public double lemonadePrice;
        public double totalSales;
        public double totalSpent;
        public double dailySales;
        public Player(string Name)
        {
            name = Name;
            money = 20.00;
        }
        public void SetRecipe()
        {
            Console.WriteLine("How much lemons would you like to use per pitcher?");
            lemonRecipe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much sugar would you like to use per pitcher?");
            sugarRecipe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much ice would you like to use per cup?");
            iceRecipe = Convert.ToInt32(Console.ReadLine());
        }

    }
}
