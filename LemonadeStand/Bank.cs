using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Bank
    {
        public Bank()
        {

        }
        public void Wallet()
        {
    
            Console.WriteLine("You currently have ${0} in your Bank");

        }
        public double BuyingSupplies()
        {
            Store store = new Store();
            double moneySpent = ((store.BuyLemons() * 0.15) + (store.BuyCups() * 0.075) + (store.BuyIce() * 0.015));
            return moneySpent;
        }
        public double TodaysGains()
        {
            Store store = new Store();
            double dayGains = (store.lemonade - BuyingSupplies()); //lemonade = number of sales!

            return dayGains;
        }
        public double TotalAmount()
        {
            double startAmount = 20 + TodaysGains();
            return startAmount;
        }
    }
}
