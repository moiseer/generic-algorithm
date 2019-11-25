using System;
using System.Collections.Generic;
using GenericAlgorithm.Core.Data;
using GenericAlgorithm.Core.Models;

namespace GenericAlgorithm.Core.Algorithms
{
    public interface IRatingFunction
    {
        double Rate(IEnumerable<Gen> genes, IEnumerable<Point> points);
    }
}
