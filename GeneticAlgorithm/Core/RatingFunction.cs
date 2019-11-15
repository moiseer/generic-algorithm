using System;
using System.Collections.Generic;
using System.Linq;
using GeneticAlgorithm.Models;

namespace GeneticAlgorithm.Core
{
    public class RatingFunction : IRatingFunction
    {
        public double Rate(IEnumerable<Gen> genes, IEnumerable<Point> points)
        {
            double errorSqr = 0;
            foreach (var point in points)
            {
                errorSqr += Math.Pow(point.Y - Function(genes, point.X), 2);
            }

            double error = Math.Sqrt(errorSqr);
            return error;
        }
        
        private double Function(IEnumerable<Gen> genes, double x)
        {
            return genes.First().Value * x + genes.Last().Value;
        }
    }
}
