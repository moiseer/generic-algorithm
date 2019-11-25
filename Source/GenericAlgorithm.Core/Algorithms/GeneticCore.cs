using System;
using System.Collections.Generic;
using System.Linq;
using GenericAlgorithm.Core.Data;
using GenericAlgorithm.Core.Models;

namespace GenericAlgorithm.Core.Algorithms
{
    public class GeneticCore
    {
        private readonly bool maximization;
        private readonly IRatingFunction ratingFunction;
        private readonly IEnumerable<Point> points;

        public GeneticCore(IRatingFunction ratingFunction, IEnumerable<Point> points, bool maximization)
        {
            this.ratingFunction = ratingFunction;
            this.maximization = maximization;
            this.points = points;
        }
        
        public double GenerationGap { get; set; } = 0.5;
        public double ClippingThreshold { get; set; } = 0.5;
        public double CrossChance { get; set; } = 0.6;
        public double MutationProbability { get; set; } = 0;
        public double MutationPercent { get; set; } = 0.1;
        
        public List<Individual> RatePopulation(List<Individual> individuals)
        {
            foreach (var individual in individuals)
            {
                double rating = ratingFunction.Rate(individual.Genes, points);
                individual.Rating = rating;
            }

            return individuals;
        }

        // Селекция усечением.
        private List<Individual> SelectIndividuals(List<Individual> ratingList, double clippingThreshold = 0.5)
        {
            if (clippingThreshold < 0 || clippingThreshold > 1)
            {
                throw new Exception("\"clippingThreshold\" must be between 0 and 1.");
            }

            int sortedCount = (int) (ratingList.Count * clippingThreshold);
            var selectedIndividuals = SelectTopIndividuals(ratingList, sortedCount);

            return selectedIndividuals;
        }

        public List<Individual> SelectTopIndividuals(IEnumerable<Individual> ratingList, int sortedCount)
        {
            IEnumerable<Individual> result;
            if (maximization)
            {
                result = ratingList.OrderByDescending(x => x.Rating);
            }
            else
            {
                result = ratingList.OrderBy(x => x.Rating);
            }

            return result.Take(sortedCount).ToList();;
        }

        private List<Individual> Crossbreeding(List<Individual> individuals, int populationSize,
            double crossChance = 0.6)
        {
            if (crossChance < 0 || crossChance > 1)
            {
                throw new Exception("\"crossChance\" must be between 0 and 1.");
            }

            var newPopulation = new List<Individual>();

            Random random = new Random();
            for (; newPopulation.Count < populationSize;)
            {
                var firstIndex = (int) (random.NextDouble() * individuals.Count);
                var first = individuals[firstIndex];
                var secondIndex = (int) (random.NextDouble() * individuals.Count);
                var second = individuals[secondIndex];
                if (crossChance > random.NextDouble())
                {
                    newPopulation.AddRange(Crossbreeding(first, second));
                }
                else
                {
                    newPopulation.Add(first);
                    newPopulation.Add(second);
                }
            }

            return newPopulation;
        }

        // Многоточечный оператор кроссинговера.
        private List<Individual> Crossbreeding(Individual firstParent, Individual secondParent)
        {
            if (firstParent.Genes.Count != secondParent.Genes.Count)
            {
                throw new Exception("Different number of genes in parents.");
            }
            
            int genesCount = firstParent.Genes.Count;
            
            Random random = new Random();
            Individual firstChild = new Individual();
            Individual secondChild = new Individual();
            for (int i=0;  i< genesCount;i++)
            {
                if (random.Next(2) == 0)
                {
                    firstChild.Genes.Add(firstParent.Genes[i]);
                }
                else
                {
                    firstChild.Genes.Add(secondParent.Genes[i]);
                }
                
                if (random.Next(2) == 0)
                {
                    secondChild.Genes.Add(firstParent.Genes[i]);
                }
                else
                {
                    secondChild.Genes.Add(secondParent.Genes[i]);
                }
            }

            return new List<Individual> {firstChild, secondChild};
        }

        private List<Individual> Mutation(List<Individual> individuals, double mutationProbability = 0, double mutationPercent = 0.1)
        {
            if (mutationProbability < 0 || mutationProbability > 1)
            {
                throw new Exception("\"mutationProbability\" must be between 0 and 1.");
            }

            if (Math.Abs(mutationProbability) < 0.000001)
            {
                mutationProbability = Math.Pow(individuals.Count, -1);
            }

            Random random = new Random();
            foreach (Individual individual in individuals)
            {
                foreach (Gen gen in individual.Genes)
                {
                    var mutationValue = Math.Abs(gen.Value) * mutationPercent + 0.1;
                    
                    if (mutationProbability > random.NextDouble())
                    {
                        var rnd = random.NextDouble();
                        gen.Value += rnd * 2 * mutationValue - mutationValue;
                    }
                }
            }

            return individuals;
        }

        public Population CreateNewGeneration(Population population)
        {
            var clone = population.Clone();
            var selectedIndividuals = SelectIndividuals(clone.Individuals, ClippingThreshold);
            
            var newIndividualsCount = (int) (population.Individuals.Count * GenerationGap);
            var newIndividuals = Crossbreeding(selectedIndividuals, newIndividualsCount, CrossChance);
            var topIndividualsCount = population.Individuals.Count - newIndividualsCount;
            var topIndividuals = SelectTopIndividuals(clone.Individuals, topIndividualsCount);
            var newPopulation = topIndividuals.Concat(newIndividuals).ToList();
            
            var mutatedPopulation = Mutation(newPopulation, MutationProbability, MutationPercent);
            
            var rating = RatePopulation(mutatedPopulation);
            var topIndividual = SelectBestIndividual(rating);

            return new Population(population.MinValue, population.MaxValue) {Individuals = rating, TopIndividual = topIndividual};
        }

        public Individual SelectBestIndividual(IEnumerable<Individual> individuals)
        {
            var bestResult = SelectTopIndividuals(individuals, 1)
                .FirstOrDefault();

            return bestResult;
        }
    }
}