using System.Threading;
using static System.Console;

namespace SOLID.InterfaceSegregation
{
    public class Car : IGroudTransportation
    {
        public void ChangeWheels()
        {
            WriteLine($"Changing the 4 wheels.....");
            Thread.Sleep(500);
            WriteLine($"This car is ready to go :D");
        }

        public void Move(Point from, Point to)
        {
            WriteLine($"Moving from {from.ToString()} to {to.ToString()} at 120 km/h");
        }
    }
}
