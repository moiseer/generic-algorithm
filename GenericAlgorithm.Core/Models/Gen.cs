using System;

namespace GeneticAlgorithm.Models
{
    public class Gen
    {
        public double Value { get; set; }

        public Gen Clone()
        {
            return new Gen {Value = Value};
        }
    }
}