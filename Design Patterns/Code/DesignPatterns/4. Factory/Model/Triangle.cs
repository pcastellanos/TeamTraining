using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._4._Factory.Model
{
    public class Triangle : IShape
    {
        public string Draw(double posX, double posY)
        {
            return $"Drawing a triangle in position X: {posX} Y: {posY}";
        }
    }
}
