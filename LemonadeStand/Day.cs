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
            Console.WriteLine($"Weather Forecast: {weather.GenerateForecast}), Temperature: {weather.temperature}°F");
            CreateCustomers(10);

            int customersWhoBought = SimulatingCustomersWalkingBy(player.recipe.price);

            int dailySales = customersWhoBought;
            double dailyProfit = dailySales * player.recipe.price;
            player.wallet.AcceptMoney(dailyProfit);

            Console.WriteLine($"Total Customers: {customers.Count}");
            Console.WriteLine($"Customers who bought Lemonade: {customersWhoBought}");
            Console.WriteLine($"Daily Profit: ${dailyProfit:F2}");
            Console.WriteLine($"Total Money in Wallet: ${player.wallet.Money:F2}");

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

            return 0;
        }
    }
}
