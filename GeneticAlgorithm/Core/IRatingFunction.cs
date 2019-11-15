using System;
using System.Collections.Generic;
using GeneticAlgorithm.Models;

namespace GeneticAlgorithm.Core
{
    public interface IRatingFunction
    {
        double Rate(IEnumerable<Gen> genes, IEnumerable<Point> points);
    }
}
