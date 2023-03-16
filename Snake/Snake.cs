using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake
    {
        public int charactersCount = 5;

        public List<Point> points;
        public Snake(int width, int height)
        {
            points = new List<Point>();
        }

        public void DrawSnake()
        {

        }
    }
}
