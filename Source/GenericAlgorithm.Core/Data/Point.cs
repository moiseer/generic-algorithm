using System;

namespace GenericAlgorithm.Core.Data
{
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X = {X: 0.00}, Y = {Y: 0.00}";
        }
    }
}
