using System;

namespace GenericAlgorithm.Core.Models
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