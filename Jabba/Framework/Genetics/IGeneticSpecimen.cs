﻿using EnderPi.Random;
using System.Collections.Generic;
using System.Drawing;

namespace EnderPi.Genetics
{
    /// <summary>
    /// Interface for a genetic specimen.
    /// </summary>
    public interface IGeneticSpecimen
    {
        public bool IsValid(out string errors);
        public int Generation { set; get; }
        public long Fitness { set; get; }
        public int Operations { get; }
        public int TestsPassed { set; get; }
        public IRandomEngine GetEngine();
        public List<IGeneticSpecimen> Crossover(IGeneticSpecimen other, RandomNumberGenerator rng);
        public void Mutate(RandomNumberGenerator rng);
        public void Fold();
        void AddInitialGenes(RandomNumberGenerator rng);
        public Bitmap GetImage(int seed, int randomsToPlot = 4096);
        public string GetDescription();
    }
}