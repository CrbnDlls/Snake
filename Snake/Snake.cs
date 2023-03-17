using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Shape
    {
        public Snake(int width, int height)
        {
            for (int i = 0; i < 5; i++)
            {
                Point point = new Point((width / 2 - 3) + i, height / 2, '*');
                _points.Add(point);
            }
        }

        public void Move(Direction direction)
        {
            Point head = _points.Last();
            Point newHead = new Point(head);

            switch (direction)
            {
                case Direction.Left:
                    newHead.X -= 1;
                    break;
                case Direction.Right:
                    newHead.X += 1;
                    break;
                case Direction.Up:
                    newHead.Y -= 1;
                    break;
                case Direction.Down:
                    newHead.Y += 1;
                    break;
            }

            _points.Add(newHead);
            newHead.Draw();
            Point tail = _points.First();
            tail.Clear();
            _points.Remove(tail);
        }

    }
}
