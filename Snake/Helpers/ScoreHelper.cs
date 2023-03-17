using System;

namespace Snake.Helpers
{
    public static class ScoreHelper
    {
        public static void ShowScore(int score, int width)
        {
            Console.SetCursorPosition(width + 2, 2);
            Console.Write($"Score: {score}");
        }

        public static void ClearScore(int width)
        {
            Console.SetCursorPosition(width + 2, 2);
            Console.Write($"              ");
        }
    }
}
