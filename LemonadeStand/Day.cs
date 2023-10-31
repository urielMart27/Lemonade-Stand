using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        public List<Customer> customers;
        public Weather weather;

        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
        }
        public void StartDay(Player player)
        {
            Console.WriteLine($"Weather Forecast: {weather.condition}), Temperature: {weather.temperature}°F");
            CreateCustomers(10);

            int customersWhoBought = SimulatingCustomersWalkingBy(player.recipe.price);

            int dailySales = customersWhoBought;
            double dailyProfit = dailySales * player.recipe.price;
            player.wallet.AcceptMoney(dailyProfit);

            Console.WriteLine($"Total Customers: {customers.Count}");
            Console.WriteLine($"Customers who bought Lemonade: {customersWhoBought}");
            Console.WriteLine($"Daily Profit: ${dailyProfit:F2}");
            Console.WriteLine($"Total Money in Wallet: ${player.wallet.Money:F2}");

            player.inventory.lemons.RemoveRange(0, Math.Min(customersWhoBought * player.recipe.numberOfLemons, player.inventory.lemons.Count));
            player.inventory.sugarCubes.RemoveRange(0, Math.Min(customersWhoBought * player.recipe.numberOfSugarCubes, player.inventory.sugarCubes.Count));
            player.inventory.iceCubes.RemoveRange(0, Math.Min(customersWhoBought * player.recipe.numberOfIceCubes, player.inventory.iceCubes.Count));
            player.inventory.cups.RemoveRange(0, Math.Min(customersWhoBought, player.inventory.cups.Count));

            Console.WriteLine("Inventory aftrer sales:");
            Console.WriteLine($"Lemons: {player.inventory.lemons.Count}");
            Console.WriteLine($"Sugar Cubes: {player.inventory.sugarCubes.Count}");
            Console.WriteLine($"Ice Cubes: {player.inventory.iceCubes.Count}");
            Console.WriteLine($"Cups: {player.inventory.cups.Count}");



            Console.WriteLine("Do you want to visit the store? (y/n)");
            string response = Console.ReadLine().ToLower();

            if (response == "y")
            {
                player.VisitStore(new Store());
            }

           

        }
        public void CreateCustomers(int numofCustomers)
        {
            for (int i = 0; i < numofCustomers; i++)
            {
                customers.Add(new Customer());
            }
        }

        public int SimulatingCustomersWalkingBy(double lemonadePrice)
        {
            int customersWhoBought = 0;

            foreach (Customer customer in customers)
            {
                if (customer.WillBuyLemonade(lemonadePrice))
                {
                    Console.WriteLine("A customer bought lemonade.");
                    customersWhoBought++;
                }
                else
                {
                    Console.WriteLine("A customer walked away.");

                }
            }

            return customersWhoBought;
        }
    }
}
