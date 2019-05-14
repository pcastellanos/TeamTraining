namespace DesignPatterns._4._Factory
{
    using Model;
    using System;
    using Factory;

    public static class FactoryTestCase
    {
        public static void DrawShapes()
        {
            IFactory factory = new ShapeFactory();

            IShape firstShape = factory.GetShape(Shapes.Circle);
            IShape secondShape = factory.GetShape(Shapes.Line);
            IShape thirdShape = factory.GetShape(Shapes.Rectangle);
            IShape forthShape = factory.GetShape(Shapes.Triangle);

            Console.WriteLine(firstShape.Draw(10.0,9.0));
            Console.WriteLine(secondShape.Draw(20.5,5.6));
            Console.WriteLine(thirdShape.Draw(30.0,0));
            Console.WriteLine(forthShape.Draw(40.0,1.1));

            Console.ReadKey();
        }
        
    }
}
