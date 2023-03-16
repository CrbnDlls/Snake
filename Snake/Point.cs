using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
            Symbol = point.Symbol;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public char Symbol { get; set; }

        public void Draw()
        {
            Console.SetCursorPosition(X,Y);
            Console.Write(Symbol);
        }

        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }

        public bool Compare(Point point)
        {
            return X == point.X && Y == point.Y;
        }
    }
}
