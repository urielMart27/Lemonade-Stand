using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Item
    {
        // member variables (HAS A)
        public string name { get; protected set; }

        // constructor (SPAWNER)
        protected Item(string itemname = "item")
        {
            name = itemname;
        
        }
      
        // member methods (CAN DO)
    }
}
