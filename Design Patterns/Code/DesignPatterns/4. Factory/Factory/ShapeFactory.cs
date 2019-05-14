namespace DesignPatterns._4._Factory.Factory
{
    using System;
    using Model;

    public class ShapeFactory: IFactory
    {
        public IShape GetShape(Shapes type)
        {
            switch (type)
            {
                case Shapes.Rectangle:
                    return new Rectangle();
                case Shapes.Line:
                    return new Line();
                case Shapes.Circle:
                    return new Circle();
                case Shapes.Triangle:
                    return new Triangle();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
