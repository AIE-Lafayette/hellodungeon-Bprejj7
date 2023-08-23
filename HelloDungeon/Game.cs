using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {   // Initliazes player stats.
            string playerName = "Kuhla";
            float damage = 3.2f;
            float health = 100.0f * 2;
            health++;
            int areaNumber = 0;
            bool playerIsAlive = true;

            //Print out name for first excersize.
            Console.WriteLine("Kane");
            Console.WriteLine("Prejean");

            //Get player input for first and last character name.
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            playerName = firstName + lastName;

            // Display character name for player feedback.
            Console.WriteLine("Hello " + playerName);
            Console.WriteLine("Welcome to Wonder City");

        }
    }
}
