using System;
using System.Linq;
using System.Text;

namespace GA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            Result_TextBox.Text = new KnapsackGA(
                                            itemCount: int.Parse(ItemCount_TextBox.Text),
                                            maxWeight: int.Parse(MaxWeight_TextBox.Text),

                                            weights: Weights_TextBox.Text.Split(new[] { ',' }, 
                                            StringSplitOptions.RemoveEmptyEntries)
                                            .Select(str => int.Parse(str.Trim()))
                                            .ToArray(),

                                            values: Values_TextBox.Text.Split(new[] { ',' },
                                            StringSplitOptions.RemoveEmptyEntries)
                                            .Select(str => int.Parse(str.Trim()))
                                            .ToArray(),

                                            populationSize: int.Parse(PopulationSize_TextBox.Text),
                                            mutationRate: double.Parse(MutationRate_TextBox.Text),
                                            elitismRate: double.Parse(ElitismRate_TextBox.Text),
                                            tournamentSize: int.Parse(TournamentSize_TextBox.Text),
                                            maxGenerations: int.Parse(MaxGenerations_TextBox.Text)
                ).Run();
           
        }
    }

    class KnapsackGA
    {
        public int ItemCount { get; set; } = 10;
        public int MaxWeight { get; set; } = 20;
        public int[] Weights { get; set; } = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        public int[] Values { get; set; } = { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        // GA parameters
        public int PopulationSize { get; set; } = 100;
        public double MutationRate { get; set; } = 0.01;
        public double ElitismRate { get; set; } = 0.1;
        public int TournamentSize { get; set; } = 5;
        public int MaxGenerations { get; set; } = 100;

        // Random number generator
        Random rand = new Random();

        // ctor
        public KnapsackGA(int itemCount, int maxWeight, int[] weights, int[] values, int populationSize, double mutationRate, double elitismRate, int tournamentSize, int maxGenerations)
        {
            ItemCount = itemCount;
            MaxWeight = maxWeight;
            Weights = weights;
            Values = values;
            PopulationSize = populationSize;
            MutationRate = mutationRate;
            ElitismRate = elitismRate;
            TournamentSize = tournamentSize;
            MaxGenerations = maxGenerations;
        }

        // Chromosome representation
        class Chromosome
        {
            public bool[] Genes { get; set; }
            public int Fitness { get; set; }
        }

        // Generate initial population
        Chromosome[] GeneratePopulation()
        {
            var population = new Chromosome[PopulationSize];
            for (int i = 0; i < PopulationSize; i++)
            {
                var genes = new bool[ItemCount];
                for (int j = 0; j < ItemCount; j++)
                {
                    genes[j] = rand.NextDouble() < 0.5; // Random binary gene
                }
                population[i] = new Chromosome { Genes = genes };
            }
            return population;
        }

        // Evaluate fitness function for a chromosome
        int EvaluateFitness(Chromosome chromosome)
        {
            int weight = 0;
            int value = 0;
            for (int i = 0; i < ItemCount; i++)
            {
                if (chromosome.Genes[i])
                {
                    weight += Weights[i];
                    value += Values[i];
                }
            }
            return (weight <= MaxWeight) ? value : 0;
        }

        // Evaluate fitness function for the entire population
        void EvaluatePopulation(Chromosome[] population)
        {
            foreach (var chromosome in population)
            {
                chromosome.Fitness = EvaluateFitness(chromosome);
            }
        }

        // Select a parent using tournament selection
        Chromosome TournamentSelection(Chromosome[] population)
        {
            var tournament = new Chromosome[TournamentSize];
            for (int i = 0; i < TournamentSize; i++)
            {
                tournament[i] = population[rand.Next(PopulationSize)];
            }
            return tournament.OrderByDescending(c => c.Fitness).First();
        }

        // Crossover two parents to create two offspring
        void Crossover(Chromosome parent1, Chromosome parent2, out Chromosome offspring1, out Chromosome offspring2)
        {
            offspring1 = new Chromosome { Genes = new bool[ItemCount] };
            offspring2 = new Chromosome { Genes = new bool[ItemCount] };
            int crossoverPoint = rand.Next(ItemCount);
            for (int i = 0; i < ItemCount; i++)
            {
                if (i < crossoverPoint)
                {
                    offspring1.Genes[i] = parent1.Genes[i];
                    offspring2.Genes[i] = parent2.Genes[i];
                }
                else
                {
                    offspring1.Genes[i] = parent2.Genes[i];
                    offspring2.Genes[i] = parent1.Genes[i];
                }
            }
        }

        // Mutate a chromosome
        void Mutate(Chromosome chromosome)
        {
            for (int i = 0; i < ItemCount; i++)
            {
                if (rand.NextDouble() < MutationRate)
                {
                    chromosome.Genes[i] = !chromosome.Genes[i]; // Flip a gene
                }
            }
        }

        // Run the genetic algorithm
        public string Run()
        {
            // To Save the results of the experiment
            var stringBuilder = new StringBuilder();

            // Generate initial population
            var population = GeneratePopulation();

            // Main loop
            for (int generation = 1; generation <= MaxGenerations; generation++)
            {
                // Evaluate fitness of the population
                EvaluatePopulation(population);

                // Sort population by fitness
                Array.Sort(population, (c1, c2) => c2.Fitness.CompareTo(c1.Fitness));

                // Print best solution of the generation
                stringBuilder.Append($"Generation {generation}: Best fitness = {population[0].Fitness}\r\n");

                // Apply elitism (keep the best individuals)
                int eliteCount = (int)(ElitismRate * PopulationSize);
                var elite = population.Take(eliteCount).ToArray();

                // Create new population by crossover and mutation
                var offspring = new Chromosome[PopulationSize - eliteCount];
                for (int i = 0; i < offspring.Length; i += 2)
                {
                    // Select parents using tournament selection
                    var parent1 = TournamentSelection(population);
                    var parent2 = TournamentSelection(population);

                    // Create offspring by crossover and mutation
                    Chromosome offspring1, offspring2;
                    Crossover(parent1, parent2, out offspring1, out offspring2);
                    Mutate(offspring1);
                    Mutate(offspring2);
                    offspring[i] = offspring1;
                    offspring[i + 1] = offspring2;
                }

                // Combine elite and offspring into new population
                population = elite.Concat(offspring).ToArray();
            }

            // Evaluate fitness of the final population
            EvaluatePopulation(population);

            // Print best solution
            var best = population.OrderByDescending(c => c.Fitness).First();

            stringBuilder.Append($"Best fitness = {best.Fitness}\r\nSelected items:\r\n");
            for (int i = 0; i < ItemCount; i++)
            {
                if (best.Genes[i])
                {
                    stringBuilder.Append($"Item {i + 1}: weight = {Weights[i]}, value = {Values[i]}\r\n");
                }
            }

            return stringBuilder.ToString();
        }
    }
}


