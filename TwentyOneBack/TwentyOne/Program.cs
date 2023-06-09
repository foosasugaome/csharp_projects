﻿using System;
using System.IO;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"D:\Logs\log.txt", text); //Write text
            string text = File.ReadAllText(@"D:\Logs\log.txt"); // Read text

            Console.WriteLine("Welcome to the Grand Hotel Casino.Let's start by telling your name.");
            string playerName =Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would  you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" ||  answer == "yeah" || answer == "y") 
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying  && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine(); 
        }
    }
}
