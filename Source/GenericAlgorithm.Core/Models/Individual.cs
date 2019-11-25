using System;
using System.Collections.Generic;

namespace GenericAlgorithm.Core.Models
{
    public class Individual
    {
        public Individual()
        {
            Genes = new List<Gen>();
        }

        public List<Gen> Genes { get; }
        public double Rating { get; set; }

        public Individual Clone()
        {
            var clone = new Individual { Rating = Rating };
            foreach (var gen in Genes)
            {
                clone.Genes.Add(gen.Clone());
            }

            return clone;
        }
    }
}
