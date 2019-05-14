namespace DesignPatterns._4._Factory
{
    using Model;

    public interface IFactory
    {
        IShape GetShape(Shapes type);
    }
}
