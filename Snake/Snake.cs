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
        private Direction _direction;
        private readonly int _width;
        private readonly int _height;
        public Snake(int width, int height)
        {
            _width = width;
            _height = height;
            for (int i = 0; i < 5; i++)
            {
                Point point = new Point((width / 2 - 3) + i, height / 2, '*');
                _points.Add(point);
            }
        }

        private void ValidateSnakeHead(Point head)
        {
            if (head.X == 0 || head.Y == 0 || head.X == _width - 1 || head.Y == _height - 1)
            {
                throw new SnakeHitBorderException();
            }
            
            if (_points.Any(x => x.Compare(head)))
            {
                throw new SnakeBiteTailException();
            }
        }

        public bool Eat(Point food)
        {
            Point head = _points.Last();
            if (head.Compare(food))
            {
                _points.Insert(0, food);
                return true;
            }
            return false;
        }

        public void Move(Direction direction)
        {
            if (!IsOposite(direction))
            {
                _direction = direction;
            }

            Point head = _points.Last();
            Point newHead = new Point(head);

            switch (_direction)
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

            ValidateSnakeHead(newHead);

            _points.Add(newHead);
            newHead.Draw();
            Point tail = _points.First();
            tail.Clear();
            _points.Remove(tail);
        }

        private bool IsOposite(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    if (_direction == Direction.Right) return true;
                    break;
                case Direction.Right:
                    if (_direction == Direction.Left) return true;
                    break;
                case Direction.Down:
                    if (_direction == Direction.Up) return true;
                    break;
                case Direction.Up:
                    if (_direction == Direction.Down) return true;
                    break;
            }
            return false;
        }

    }
}
