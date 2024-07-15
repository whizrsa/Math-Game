using Math_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();
        internal void ShowMenu(string name,DateTime date, List<Game> games)
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. That's great you are wroking on improving yourself");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();

                Console.WriteLine($@"What game would you like to play today? Choose from the options below: 
                V - View Previous Games
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                Q - Quit the program
                ");
                Console.WriteLine("===========================");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition Game", games);
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction Game", games);
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication Game", games);
                        break;
                    case "d":
                        engine.DivisionGame("Division Game", games);
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Environment.Exit(1);
                        break;
                }

            } while (isGameOn);
        }
    }
}
