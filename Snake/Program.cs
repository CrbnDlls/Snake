﻿using Snake.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
                    DisplayWelcomeScreen(width, height);
                }

            }
        }

        private static void ApplyConsoleSettings(int width, int height)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            Border border = new Border(width, height);
            border.Draw();
            
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
            
            for (int i = 1; i < height - 1; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                }
            }
        }
                
        private static void StartNewGame(int width, int height)
        {
            ClearConsole(width, height);

            Snake snake = new Snake(width,height);
            snake.Draw();

            Direction direction = Direction.Right;

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.F12)
                    { 
                        break;
                    }

                    switch (keyInfo.Key) 
                    {
                        case ConsoleKey.UpArrow:
                            direction = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Direction.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            direction = Direction.Right;
                            break;
                    }
                }
                
                Thread.Sleep(100);
                snake.Move(direction);
            }

        }
    }
}
