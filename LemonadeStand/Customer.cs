using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        double willingnesstopay;
       

        public Customer()
        {
            Random rand = new Random();
            willingnesstopay = rand.Next(50, 101) / 100.0;
        }

        public bool WillBuyLemonade(double price)
        {
            return willingnesstopay >= price;
        }
      
        
    }
}
