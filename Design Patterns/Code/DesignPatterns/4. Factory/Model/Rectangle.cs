using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._4._Factory.Model
{
    public class Rectangle : IShape
    {
        public string Draw(double posX, double posY)
        {
            return $"Drawing a rectangle in position X: {posX} Y: {posY}";
        }
    }
}
