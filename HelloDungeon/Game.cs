﻿using System;
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
            float health = 100f;
            float stamina = 100f;
            float durability = 100f;
            bool playerIsAlive = true;

            Console.WriteLine("Mysterious Voice: What is your name?");



            //Get player input for first and last character name.
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            playerName = firstName + lastName;

            // Displaying a message from mysterious voice.
            Console.WriteLine("Mysterious voice: Hello " + playerName);
            Console.WriteLine("Welcome to Wonder City");
            Console.WriteLine("Wonder City is a city full of wonder if you couldn't guess by the name.");
            Console.WriteLine("Now before you continue to wonder the city of Wonder, I will need you to pick your elemental ability.");
            Console.WriteLine("However pick carefully because once you choose your element, you cannot change it");


            //Getting player to choose elemental ability.
            Console.WriteLine("1. Ice?");
            Console.WriteLine("2. Water?");
            Console.WriteLine("3. Fire?");
            Console.WriteLine("4. Air?");
            Console.WriteLine("5. Lightning?");

            string playerChoice = Console.ReadLine();


            if (playerChoice == "Ice" || playerChoice == "1")
            {
                Console.WriteLine("Mysterious Voice: You have picked Ice? Ok if that's what you want.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
            else if (playerChoice == "Water" || playerChoice == "2")
            {
                Console.WriteLine("Mysterious Voice: Ahh water, defintely my personal favorite option. Excellent choice " + playerName);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
            else if (playerChoice == "Fire" || playerChoice == "3")
            {
                Console.WriteLine("Mysterious Voice: That's the more popular choice so that makes you basic you loser. But it is still pretty cool so nice choice.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
            else if (playerChoice == "Air" || playerChoice == "4")
            {
                Console.WriteLine("Mysterious Voice: Air users death rate is the highest out of everyone else here due to the ability of being able to fly. But you can fly so it's cool");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
            else if (playerChoice == "Lightning" || playerChoice == "5")
            {
                Console.WriteLine("Mysterious Voice: Just please don't electrocute your classmates or other people in general");

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
            Console.WriteLine("Now that you have chosen your elemental ability, it's time to choose what atribute you want to excel in.");

            //Getting player to choose their attributes
            Console.WriteLine("6. Altheticism");
            Console.WriteLine("7. Super Strength");
            Console.WriteLine("8. High Pain Tolerance");

           

            if (playerChoice == "Athleticism" || playerChoice == "6")
            {
                Console.WriteLine("Athleticism allows you to move with ease and increases your stamina by 50");
                stamina = +50;
            }
            

        }
    }
}
