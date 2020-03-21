using static System.Console;

namespace SOLID.InterfaceSegregation
{
    public class Ship : IConveyance
    {
        public void ChangeWheels()
        {
            throw new System.NotImplementedException();
        }

        public void Move(Point from, Point to)
        {
            WriteLine($"Moving from {from.ToString()} to {to.ToString()} at 30 km/h");
        }
    }
}
