using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace SOLID.Liskov
{
    public class CalculateAreaBetterImplementation
    {
        public static void CalculateArea()
        {
            WriteLine("2X3 rectangle, area should return 6");
            ReadLine();
            var area = new Rectangle { Height = 2, Width = 3 }.Area();
            WriteLine("Result: " + area);

            ReadLine();
            WriteLine("3X3 square, area should return 9");
            ReadLine();
            area = new Square { SideLength = 3 }.Area();
            WriteLine("Result: " + area);

            ReadLine();
            WriteLine("4X5 rectangle using square class, area should return 20");
            ReadLine();
            Shape myShape = new Rectangle() { Height = 5, Width = 4 };
            area = myShape.Area();
            WriteLine("Result: " + area);
            ReadLine();

            var shapes = new List<Shape>
            {
                new Rectangle {Height = 2, Width = 3},
                new Square {SideLength = 3}
            };

            foreach (var shape in shapes)
            {
                WriteLine("Result: " + shape.Area());
                ReadLine();
            }
        }

        public abstract class Shape
        {
            public abstract int Area();
        }

        public class Rectangle : Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public override int Area()
            {
                return Height * Width;
            }
        }

        public class Square : Shape
        {
            public int SideLength { get; set; }

            public override int Area()
            {
                return SideLength * SideLength;
            }
        }
    }
}
