using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Basic
{
    class Cerveau
    {
        private Neurones[] Neurones;
        private Neurones LastNeurone;
        public Cerveau(int celluleNumber)
        {
            Neurones = new Neurones[celluleNumber];
            for (int i = 0; i < celluleNumber; i++)
            {
                Neurones[i] = new Neurones();
            }

            LastNeurone = new Neurones();
        }

        public double Reflexion(double Stimulus)
        {
            List<double> NeuroneSynapseResults = new List<double>();
            foreach (Neurones neurone in Neurones)
            {
                NeuroneSynapseResults.Add(neurone.Synapse(Stimulus));
            }

            List<double> NeuronesResults = new List<double>();
            foreach (Neurones neurone in Neurones)
            {
                NeuronesResults.Add(neurone.Neurone(NeuroneSynapseResults));
            }

            double Result = LastNeurone.Neurone(NeuronesResults) / Math.Pow(Neurones.Length, 2);

            return Result;
        }

        public void Correction(double goodAnswer)
        {
            foreach (Neurones neurone in Neurones)
            {
                if (neurone.result != goodAnswer)
                {
                    neurone.Correction(true, goodAnswer);
                }
                else
                {
                    neurone.Correction(false, goodAnswer);
                }
            }

            Console.WriteLine("Corrections faites !");
        }
    }
}
