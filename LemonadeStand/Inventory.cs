using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public double lemon;
        public double ice;
        public double cups;
        public Inventory()
        {
        }
        public void CurrentInventory()
        {
            Console.WriteLine("You currently have:\n {0} lemons\n {1} Ice\n {2} cups", lemon, ice, cups);
        }
       
    }
}
