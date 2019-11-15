using System.Collections.Generic;

namespace GeneticAlgorithm.Models
{
    public class Individual
    {
        public List<Gen> Genes { get; set; }
        public double Rating { get; set; }

        public Individual()
        {
            Genes = new List<Gen>();
        }

        public Individual Clone()
        {
            var clone = new Individual {Genes = new List<Gen>(), Rating = Rating};
            foreach (var gen in Genes)
            {
                clone.Genes.Add(gen.Clone());
            }

            return clone;
        }
    }
}