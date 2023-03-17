using System;

namespace Snake
{
    internal class FoodFactory
    {
        private readonly Random random;

        public FoodFactory()
        {
            random = new Random();
        }
        public Point GetFood(int width, int height)
        {
            return new Point(random.Next(1, width - 1), random.Next(1, height - 1), '+');
        }
    }
}
