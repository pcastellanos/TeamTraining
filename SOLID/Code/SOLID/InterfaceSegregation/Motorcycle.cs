using System.Threading;
using static System.Console;

namespace SOLID.InterfaceSegregation
{
    public class Motorcycle : IGroudTransportation
    {
        public void ChangeWheels()
        {
            WriteLine($"Changing the 2 wheels.....");
            Thread.Sleep(500);
            WriteLine($"This motorcycle is ready to go :D");
        }

        public void Move(Point from, Point to)
        {
            WriteLine($"Moving from {from.ToString()} to {to.ToString()} at 80 km/h");
        }
    }
}
