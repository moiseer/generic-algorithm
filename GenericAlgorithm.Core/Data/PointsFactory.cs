using System;
using System.Collections.Generic;
using GenericAlgorithm.Core.Models;

namespace GenericAlgorithm.Core.Data
{
    public class PointsFactory
    {
        public List<Point> CreateRandomPoints()
        {
            Random random = new Random();
            var points = new List<Point>
            {
                new Point(random.Next(0, 10), random.Next(0, 10)),
                new Point(random.Next(10, 20), random.Next(10, 20)),
                new Point(random.Next(20, 30), random.Next(20, 30)),
                new Point(random.Next(30, 40), random.Next(30, 40)),
                new Point(random.Next(40, 50), random.Next(40, 50))
            };
            
            return points;
        }
        
        public List<Point> CreateLinePoints()
        {
            Random random = new Random();
            var points = new List<Point>
            {
                new Point(random.Next(0, 10), random.Next(0, 10)),
                new Point(random.Next(10, 20), random.Next(10, 20)),
                new Point(random.Next(20, 30), random.Next(20, 30)),
                new Point(random.Next(30, 40), random.Next(30, 40)),
                new Point(random.Next(40, 50), random.Next(40, 50))
            };
            
            return points;
        }
    }
}
