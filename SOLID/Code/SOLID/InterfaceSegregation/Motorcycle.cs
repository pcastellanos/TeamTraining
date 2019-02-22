using static System.Console;

namespace SOLID.InterfaceSegregation
{
    public class Motorcycle : ITransportation
    {
        public void ChangeWheels()
        {
            WriteLine($"Changing 2 wheels");
        }

        public void Move(Point from, Point to)
        {
            WriteLine($"Moving from {from.ToString()} to {to.ToString()} at 80 km/h");
        }
    }
}
