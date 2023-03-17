using Snake.Enums;

namespace Snake
{
    internal class Border
    {
        private readonly int width;
        private readonly int height;

        public Border(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            int LastX = width - 1;
            int LastY = height - 1;


            HorisontalLine topLine = new HorisontalLine(width - 2, 1, 0);
            topLine.Draw();

            HorisontalLine bottomLine = new HorisontalLine(width - 2, 1, LastY);
            bottomLine.Draw();

            VerticalLine leftLine = new VerticalLine(height - 2, 0, 1);
            leftLine.Draw();

            VerticalLine rightLine = new VerticalLine(height - 2, LastX, 1);
            rightLine.Draw();

            Corner topLeftCorner = new Corner(CornerType.TopLeft, 0, 0);
            topLeftCorner.Draw();

            Corner topRightCorner = new Corner(CornerType.TopRight, LastX, 0);
            topRightCorner.Draw();

            Corner bottomLeftCorner = new Corner(CornerType.BottomLeft, 0, LastY);
            bottomLeftCorner.Draw();

            Corner bottomRightCorner = new Corner(CornerType.BottomRight, LastX, LastY);
            bottomRightCorner.Draw();
        }
    }

    internal class HorisontalLine : Shape
    {
        public HorisontalLine(int length, int x, int y)
        {
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(x + i, y, '\u2550'); // ═
                _points.Add(point);
            }
        }
    }

    internal class VerticalLine : Shape
    {
        public VerticalLine(int length, int x, int y)
        {
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(x, y + i, '\u2551'); // ║
                _points.Add(point);
            }
        }
    }
    internal class Corner : Shape
    {
        public Corner(CornerType? position, int x, int y)
        {
            char symbol = '\u2554'; //╔

            switch (position)
            {
                case CornerType.TopLeft:
                    symbol = '\u2554'; //╔
                    break;
                case CornerType.TopRight:
                    symbol = '\u2557'; // ╗
                    break;
                case CornerType.BottomLeft:
                    symbol = '\u255A'; //╚
                    break;
                case CornerType.BottomRight:
                    symbol = '\u255D'; // ╝
                    break;
            }

            Point point = new Point(x, y, symbol);
            _points.Add(point);
        }
    }

}
