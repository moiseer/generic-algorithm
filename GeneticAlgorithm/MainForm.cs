using System;
using System.Windows.Forms;
using GenericAlgorithm.Core.Algorithms;
using GenericAlgorithm.Core.Data;
using GeneticAlgorithm.Models;

namespace GeneticAlgorithm
{
    public partial class MainForm : Form
    {
        private readonly GenericService service;
        private readonly PointsFactory pointsFactory;
        
        public MainForm()
        {
            InitializeComponent();
            pointsFactory = new PointsFactory();
            service = new GenericService(new RatingFunction(), pointsFactory.CreateLinePoints());
            for (var i = 0; i < service.Points.Count; i++)
            {
                PointListBox.Items.Add($"Point {i}: {service.Points[i].ToString()}");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            service.InitCore(
                (double) ClippingThresholdUpDown.Value,
                (double) CrossChanceUpDown.Value,
                (double) GenerationGapUpDown.Value,
                (double) MutationPercentUpDown.Value,
                (double) MutationProbabilityUpDown.Value);

            Individual result = new Individual();
            try
            {
                result = service.GetResult(
                    (int) PopulationSizeUpDown.Value,
                    (int) PopulationCountUpDown.Value);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show(exception.Message);
            }

            ResultTextBox.Text = $@"A = {result.Genes[0].Value: 0.00}, B = {result.Genes[1].Value: 0.00}";

            PopulationListBox.Items.Clear();
            for (var i = 0; i < service.PopulationHistory.Count; i++)
            {
                var population = service.PopulationHistory[i];
                PopulationListBox.Items.Add($"Population {i}: Top = {population.TopIndividual.Rating: 0.00}");
            }
        }

        private void PopulationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = PopulationListBox.SelectedIndex;
            if(index<0 || index>=service.PopulationHistory.Count)
            {
                return;
            }
            
            IndividualListBox.Items.Clear();
            var population = service.PopulationHistory[index];
            for (var i = 0; i < population.Individuals.Count; i++)
            {
                var individual = population.Individuals[i];
                IndividualListBox.Items.Add(
                    $"Individual {i} ({individual.Rating: 0.00}): " +
                    $"A = {individual.Genes[0].Value: 0.00}, " +
                    $"B = {individual.Genes[1].Value: 0.00}");
            }
        }

        private void UpdatePointsButton_Click(object sender, EventArgs e)
        {
            service.Points = pointsFactory.CreateRandomPoints();
            PointListBox.Items.Clear();
            for (var i = 0; i < service.Points.Count; i++)
            {
                PointListBox.Items.Add($"Point {i}: {service.Points[i].ToString()}");
            }
        }
    }
}