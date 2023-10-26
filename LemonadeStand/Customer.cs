using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        int thirstLevel;
        double budget;

        public Customer()
        {
            thirstLevel = new Random().Next(1, 10);
            budget = new Random().Next(1, 20);

        }
        public int GetThirstLevel()
        {
            return thirstLevel;
        }
        public double GetBudget()
        {
            return budget;
        }
        public bool CustomerDecision(double lemonadeprice, Weather weather)
        {
            double maxPriceForCustomer = GetBudget();

                if (lemonadeprice <= maxPriceForCustomer)
            {
                return true;
            }
            return false;
           




        }
    }
}
