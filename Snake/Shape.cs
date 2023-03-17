using System;
using System.Collections.Generic;

namespace Snake
{
    internal class Shape
    {
        protected List<Point> _points;

        public Shape()
        {
            _points = new List<Point>();
        }

        public void Draw()
        {
            foreach (var item in _points)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write(item.Symbol);
            }
        }
    }
}
