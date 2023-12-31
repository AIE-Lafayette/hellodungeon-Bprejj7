﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloDungeon
{

    class Game
    {
        // Initliazes player stats.
        string playerName = "";
        string playerChoice = "";
        float playerHealth = 100f;
        float playerStamina = 100f;
        float playerDurability = 100f;
        bool enemyIsAlive = false;
        bool gameOver = false;
        int currentScene = 1;
        bool abilitySelected = true;

        //Using functions to create stats
        void PrintStats(string name, float health, float stamina, float durability)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Stamina: " + stamina);
            Console.WriteLine("Durability: " + durability);

        }
        string DisplayMenu(string prompt, string option1, string option2, string option3)
        {
            string playerChoice = "";

            //Main menu
            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {

                Console.Clear();
                Console.WriteLine(prompt);
                //Display all options.
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("3." + option3);

                //Get player input
                Console.Write("> ");
                playerChoice = Console.ReadLine();

                //If the player input is not one of the available options...
                if (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
                {
                    //... display the error message.
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);

                }

            }

            return playerChoice;

        } 
        void DisplayScene0()
        {
            currentScene = 0;
            string playerChoice = "";
            while (playerChoice != "1")
            {

                Console.WriteLine("Mysterious Voice: What is your name?");

                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                playerName = firstName + lastName;

                Console.Write(">");

                Console.WriteLine("Ah " + playerName + "!. Am I pronouncing that correctly?");

                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                Console.Write(">");
                playerChoice = Console.ReadLine();

                Console.Clear();
                if (playerChoice == "1")
                {
                    Console.WriteLine("What a great name!");
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("Sorry about that!");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey(true);
                    
                }
                
            }
            PrintStats(playerName, playerHealth, playerStamina, playerDurability);



        }
        void DisplayScene1()
        {
            // Displaying a message from mysterious voice.

            Console.WriteLine("Welcome to Wonder City" + playerName);
            Console.WriteLine("Wonder City is a city full of wonder if you couldn't guess by the name.");
            Console.WriteLine("Now before you continue to wonder the city of Wonder, I will need you to pick your elemental ability.");
            Console.WriteLine("However pick carefully because once you choose your element, you cannot change it");


            //Getting player to choose elemental ability.
            Console.WriteLine("1. Ice?");
            Console.WriteLine("2. Water?");
            Console.WriteLine("3. Fire?");
            Console.WriteLine("4. Air?");
            Console.WriteLine("5. Lightning?");

            bool invalidInputRecieved = false;
            string playerChoice;
            playerChoice = Console.ReadLine();


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
            else
            {
                playerChoice = "";
                invalidInputRecieved = true;
                Console.WriteLine("Invalid Input");
            }
            //Seeing if player is sure with their choice.

            playerChoice = "";
            while (playerChoice != "1" && invalidInputRecieved == false)
            {
                Console.WriteLine("Are you sure you want this elemental ability?");
                Console.WriteLine("1. Yes!");
                Console.WriteLine("2. No!");

                playerChoice = Console.ReadLine();

                Console.Clear();
                if (playerChoice == "1")
                {
                    abilitySelected = true; 
                    currentScene = 1;
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("Next time, BE SURE!");
                    abilitySelected = false;
                }
                else
                Console.WriteLine("Invalid Input fool. Pick again!");
                Console.ReadKey(true);
            }

            PrintStats(playerName, playerHealth, playerStamina, playerDurability);


        }
        void DisplayScene2()
        {
            Console.WriteLine("Now that you have chosen your elemental ability, it's time to choose what atribute you want to excel in.");

            //Getting player to choose their attributes
            Console.WriteLine("6. Altheticism?");
            Console.WriteLine("7. Super Strength?");
            Console.WriteLine("8. High Pain Tolerance?");

            playerChoice = Console.ReadLine();

            if (playerChoice == "Athleticsm" || playerChoice == "6")
            {

                Console.WriteLine("Athleticsm will increase your stamina by 50");
                playerStamina =+ 50;
            }
            else if (playerChoice == "Super Strength" || playerChoice == "7")
            {
                Console.WriteLine("Super Strenth will increase your health by 50");
                playerHealth =+ 50;
            }
            else if (playerChoice == "High Pain Tolerance" || playerChoice == "8")
            {
                Console.WriteLine("High Pain Tolerance will increase your durability by 50");
                playerDurability =+ 50;
            }
            //Seeing if player is sure with their choice.

            Console.WriteLine("Are you sure you want this atribute?");
            Console.WriteLine("1. Yes!");
            Console.WriteLine("2. No!");

            playerChoice = Console.ReadLine();


            Console.Clear();
            while (playerChoice != "1") 
            {

                if (playerChoice == "1")
                {
                    abilitySelected = true;
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("You gotta be kidding me. CHOOSE AGAIN!");
                    abilitySelected = false;
                }
                else
                Console.WriteLine("Invalid Input fool. Pick again!");
                Console.ReadKey(true);

                currentScene = 2;
            }



        }
        void DisplayScene3()
        {
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("That's it! Wanna play again?");

                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("> ");

                playerChoice = Console.ReadLine();

                if (playerChoice == "2")
                {
                    gameOver = true;
                }
                else if (playerChoice != "1")
                {
                    Console.WriteLine("Invaild Input");
                    gameOver = false;

                    currentScene = 3;

                }
            }
        }

        public void Run()
        {
            while (gameOver == false)
            {
                if (currentScene == 0)
                {
                    DisplayScene0();
                }       
                else if (currentScene == 1)
                {
                    DisplayScene1();
                }
                else if (currentScene == 2)
                {
                    DisplayScene2();
                }
                else if (currentScene == 3)
                {
                    DisplayScene3();
                }
            }
        }
    }
}


