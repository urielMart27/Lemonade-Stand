using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)

        public void VisitStore(Store store)
        {
           



            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("1. Lemons");
            Console.WriteLine("2. Ice Cubes");
            Console.WriteLine("3. Sugar Cubes?");
            Console.WriteLine("4. Cups");
            Console.WriteLine("5. Exit Store");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    store.SellLemons(this);
                    break;
                case "2":
                    store.SellIceCubes(this);
                    break;
                case "3":
                    store.SellSugarCubes(this);
                    break;
                case "4":
                    store.SellCups(this);
                    break;
                case "5":
                    Console.WriteLine("Exiting store...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    VisitStore(store);
                    break;

                   
                    
            }
            recipe.DisplayRecipe();

            Console.WriteLine("Do you want to change your recipe? (y/n)");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                Console.WriteLine("Enter the number of lemons per pitcher:");
                int lemons = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of sugar cubes per pitcher:");
                int sugar = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of ice cubes per pitcher:");
                int ice = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Price per cup:");
                int pricePerCup = Int32.Parse(Console.ReadLine());

                recipe.CustomizeRecipe(lemons, sugar, ice, pricePerCup);
                Console.WriteLine("Recipe Changed");
                recipe.DisplayRecipe();
            }

        }
        
        
    }

}
