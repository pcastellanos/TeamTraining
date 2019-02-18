using static System.Console;

namespace SOLID.Liskov
{
    public class CalculateAreaBadImplementation
    {
        public static void CalculateArea()
        {
            WriteLine("2X3 rectangle, area should return 6");
            ReadLine();
            var area = CalculateArea(new Rectangle { Height = 2, Width = 3 });
            WriteLine("Result: " + area);

            ReadLine();
            WriteLine("3X3 square, area should return 9");
            ReadLine();
            area = CalculateArea(new Square { Height = 3 });
            WriteLine("Result: " + area);

            ReadLine();
            WriteLine("4X5 rectangle using square class, area should return 20");
            ReadLine();
            Rectangle rectangle = new Square();
            rectangle.Width = 4;
            rectangle.Height = 5;
            area = CalculateArea(rectangle);
            WriteLine("Result: " + area);
            ReadLine();
        }

        public static int CalculateArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static int CalculateArea(Square square)
        {
            return square.Height * square.Height;
        }
    }

    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    public class Square : Rectangle
    {
        private int _height;
        private int _width;

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;
            }
        }

        public override int Height
        {
            get { return _height; }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}
