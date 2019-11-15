using System;
using System.Collections.Generic;

namespace GeneticAlgorithm.Models
{
    public class Population
    {
        public List<Individual> Individuals { get; set; }
        public Individual TopIndividual { get; set; }
        
        public double MinValue { get; private set; }
        public double MaxValue { get; private set; }

        public Population(double minValue, double maxValue)
        {
            Individuals = new List<Individual>();
            MaxValue = maxValue;
            MinValue = minValue;
        }
        
        public static Population CreatePopulation(int individualsCount, int genesCount, double minValue = 0, double maxValue = 1)
        {
            Population population = new Population(minValue, maxValue);
            Random random = new Random();
            for (int i = 0; i < individualsCount; i++)
            {
                Individual individual = new Individual();
                for (int j = 0; j < genesCount; j++)
                {
                    Gen gen = new Gen {Value = random.NextDouble() * (maxValue - minValue) + minValue};

                    individual.Genes.Add(gen);
                }
                population.Individuals.Add(individual);
            }

            return population;
        }

        public Population Clone()
        {
            var clone = new Population(MinValue, MaxValue) {TopIndividual = TopIndividual.Clone()};
            foreach (var individual in Individuals)
            {
                clone.Individuals.Add(individual.Clone());
            }

            return clone;
        }
    }
}