using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    /// <summary>
    /// Class to show Interface Segregation Test Case
    /// </summary>
    internal static class ISTestCase
    {
        internal static void Start()
        {
            Point pStart = new Point(10, 50);
            Point pEnd = new Point(150, 59);

            Car car = new Car();
            Motorcycle moto = new Motorcycle();

            Console.WriteLine("Move Car");
            car.Move(pStart, pEnd);
            Console.ReadLine();
            Console.WriteLine("changing wheels");
            car.ChangeWheels();
            Console.ReadLine();

            Console.WriteLine("Move Motorcycle");
            moto.Move(pStart, pEnd);
            Console.ReadLine();
            Console.WriteLine("changing wheels");
            moto.ChangeWheels();
            Console.ReadLine();

            // Bad Case
            Ship ship = new Ship();

            Console.WriteLine("Move Ship");
            ship.Move(pStart, pEnd);
            Console.ReadLine();
            Console.WriteLine("changing wheels");
            ship.ChangeWheels();
            Console.ReadLine();

            // Good Case
            //Ship ship = new Ship();

            //Console.WriteLine("Move Ship");
            //ship.Move(pStart, pEnd);
            //Console.ReadLine();
            //Console.WriteLine("Dropping anchors...");
            //ship.DropAnchor();
            //Console.ReadLine();
        }
    }
}
