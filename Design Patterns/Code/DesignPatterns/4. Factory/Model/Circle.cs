using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._4._Factory.Model
{
    public class Circle : IShape
    {
        public string Draw(double posX, double posY)
        {
            return $"Drawing a circle in position X: {posX} Y: {posY}";
        }
    }
}
