using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int lemon;
        public int ice;
        public int cups;
        public int sugar;
        public int pitcher;
        public Inventory()
        {
        }
        public void CurrentInventory()
        {
            Console.WriteLine("You currently have:\n {0} lemons\n {1} Ice\n {2} cups\n {3} sugar", lemon, ice, cups, sugar);
        }
        public void SetLemonade()
        {

        }
       
    }
}
