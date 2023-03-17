using System;

namespace Snake.Helpers
{
    internal static class GameOverHelper
    {
        public static void ShowGameOverScreen(string message, int width, int height)
        {
            Console.SetCursorPosition((width / 2 - 5), (height / 2 - 1));

            Console.Write("Game Over");

            Console.SetCursorPosition((width / 2 - 14), (height / 2 + 1));

            Console.Write(message);

            Console.SetCursorPosition((width / 2 - 14), (height / 2 + 3));

            Console.Write("Press \"Enter\" to continue...");

            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
        }
    }
}
