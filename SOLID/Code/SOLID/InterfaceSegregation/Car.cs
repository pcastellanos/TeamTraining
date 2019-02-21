﻿using static System.Console;

namespace SOLID.InterfaceSegregation
{
    public class Car : ITransportation
    {
        public void Move(Point from, Point to)
        {
            WriteLine($"Moving from {from.ToString()} to {to.ToString()} at 120 km/h");
        }
    }
}