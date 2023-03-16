using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 60, height = 29;

            ApplyConsoleSettings(width, height);
            
            while (true)
            {
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.F12)
                {
                    break;
                }
                else if (consoleKey == ConsoleKey.F2) 
                {
                    StartNewGame(width, height);
                }

            }
        }

        private static void ApplyConsoleSettings(int width, int height)
        {
            Console.OutputEncoding = Encoding.Unicode;

            

            DrawBorder(width, height);

            Console.CursorVisible = false;

            DisplayWelcomeScreen(width, height);
            Console.SetCursorPosition(1, 1);
        }

        private static void DisplayWelcomeScreen(int width, int height)
        {
            Console.SetCursorPosition((width / 2 - 14), (height / 2 - 1));

            Console.WriteLine("Press F2 to start a new Game");

            Console.SetCursorPosition((width / 2 - 9), (height / 2 + 1));

            Console.WriteLine("Press F12 to exit");
        }

        private static void ClearConsole(int width, int height)
        {
            
            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j < width; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                }
            }
        }

        private static void DrawBorder(int width, int height)
        {
            Console.Write('\u2554'); //╔

            for (int i = 1; i < width; i++)
            {
                Console.Write('\u2550'); // ═
            }

            Console.Write('\u2557'); // ╗

            for (int j = 1; j < height; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.Write('\u2551'); // ║
                Console.SetCursorPosition(width, j);
                Console.Write('\u2551'); // ║
            }

            Console.SetCursorPosition(0, height);

            Console.Write('\u255A'); //╚

            for (int i = 1; i < width; i++)
            {
                Console.Write('\u2550'); // ═
            }

            Console.Write('\u255D'); // ╝
        }

        private static void StartNewGame(int width, int height)
        {
            ClearConsole(width, height);

            Snake snake = new Snake(width,height);
        }
    }
}
