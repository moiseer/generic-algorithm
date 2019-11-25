using System;
using System.Collections.Generic;
using System.Linq;
using GenericAlgorithm.Core.Data;
using GenericAlgorithm.Core.Models;

namespace GenericAlgorithm.Core.Algorithms
{
    public class GenericService
    {
        private GeneticCore geneticCore;
        private readonly int genesCount = 2;
        private readonly double maxValue = 1000000;
        private readonly double minValue = -1000000;
        private readonly IRatingFunction ratingFunction;
        
        public IList<Point> Points { get; set; }
        public List<Population> PopulationHistory { get; set; }

        public GenericService(IRatingFunction ratingFunction, IList<Point> points)
        {
            this.ratingFunction = ratingFunction;
            Points = points;
        }

        public void InitCore(double clippingThreshold, double crossChance, double generationGap, double mutationPercent, double mutationProbability)
        {
            geneticCore = new GeneticCore(ratingFunction, Points, false)
            {
                ClippingThreshold = clippingThreshold,
                CrossChance = crossChance,
                GenerationGap = generationGap,
                MutationPercent = mutationPercent,
                MutationProbability = mutationProbability
            };
        }

        public Individual GetResult(int populationSize, int populationCount)
        {
            var firstPopulation = Population.CreatePopulation(populationSize, genesCount, minValue, maxValue);
            firstPopulation.Individuals = geneticCore.RatePopulation(firstPopulation.Individuals);
            firstPopulation.TopIndividual = geneticCore.SelectBestIndividual(firstPopulation.Individuals);
            PopulationHistory = new List<Population> {firstPopulation};
            
            for (int i = 0; i < populationCount-1; i++)
            {
                var newPopulation = geneticCore.CreateNewGeneration(PopulationHistory[i]);
                PopulationHistory.Add(newPopulation);
            }

            var bestResults = PopulationHistory.Select(x => x.TopIndividual);
            var bestResult = geneticCore.SelectBestIndividual(bestResults);
            
            return bestResult;
        }
    }
}