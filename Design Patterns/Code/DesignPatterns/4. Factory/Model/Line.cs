using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._4._Factory.Model
{
    public class Line : IShape
    {
        public string Draw(double posX, double posY)
        {
            return $"Drawing a line in position X: {posX} Y: {posY}";
        }
    }
}
