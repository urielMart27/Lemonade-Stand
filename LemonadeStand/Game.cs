using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        private List<Day> days;
        private int currentday;
        public Player player;

        public Game()
        {
            days = new List<Day>();
            currentday = 0;
            player = new Player();
            InitializeGame();

          
        }
        public void InitializeGame()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
        }
        public void RunGame()
        {
           

            while (currentday < days.Count)
            {
                Console.WriteLine($"Day {currentday + 1}");

                Console.WriteLine("Inventory:");
                Console.WriteLine($"Lemons: {player.inventory.lemons.Count}");
                Console.WriteLine($"Sugar Cubes: {player.inventory.sugarCubes.Count}");
                Console.WriteLine($"Ice Cubes: {player.inventory.iceCubes.Count}");
                Console.WriteLine($"Cups: {player.inventory.cups.Count}");

                Console.WriteLine("Press Enter to start the day...");
                Console.ReadLine();

                Day currentDayObject = days[currentday];


                currentDayObject.StartDay(player);
                currentday++;
            }
            Console.WriteLine("End of Week!");

         
        }
    }
}
