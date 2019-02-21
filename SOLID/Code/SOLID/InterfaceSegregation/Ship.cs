using static System.Console;

namespace SOLID.InterfaceSegregation
{
    public class Ship : IMarineTransportation
    {
        public void DropAnchor()
        {
            WriteLine($"Dropping Anchor!!!");
        }

        public void Move(Point from, Point to)
        {
            WriteLine($"Moving from {from.ToString()} to {to.ToString()} at 30 km/h");
        }
    }
}
