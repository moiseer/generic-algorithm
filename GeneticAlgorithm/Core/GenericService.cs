using System;
using System.Collections.Generic;
using System.Linq;
using GeneticAlgorithm.Models;

namespace GeneticAlgorithm.Core
{
    public class GenericService
    {
        private GeneticCore geneticCore;
        private readonly int genesCount = 2;
        private readonly double maxValue = 1000000;
        private readonly double minValue = -1000000;
        private readonly IRatingFunction ratingFunction;
        
        public List<Point> Points { get; set; }
        public List<Population> PopulationHistory { get; set; }

        public GenericService(IRatingFunction ratingFunction)
        {
            this.ratingFunction = ratingFunction;
            
            Points = new List<Point>
            {
                new Point(0, 0),
                new Point(10, 10),
                new Point(20, 20),
                new Point(30, 30),
                new Point(40, 40)
            };
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

        public List<Point> CreatePoints()
        {
            Random random = new Random();
            var points = new List<Point>
            {
                new Point(random.Next(0, 10), random.Next(0, 10)),
                new Point(random.Next(10, 20), random.Next(10, 20)),
                new Point(random.Next(20, 30), random.Next(20, 30)),
                new Point(random.Next(30, 40), random.Next(30, 40)),
                new Point(random.Next(40, 50), random.Next(40, 50))
            };
            
            return points;
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