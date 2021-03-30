using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Basic
{
    class Neurones
    {
        private int[] mutation = new int[100000000]; //Modification aléatoire du comportement à chaque essai

        private double weight; //Information envoyé à la cellule

        public double result; //Résultat que donne la cellule

        public double stimulusReturn;

        public Neurones()
        {
            Random r = new Random();
            mutation[0] = 0;
            mutation[1] = 1;
            weight = r.Next(mutation[0] - (mutation.Length / 4), mutation[1] - (mutation.Length / 4));

            Console.WriteLine("weight = " + weight);
        }

        public double Synapse(double Stimulus)
        {
            Stimulus *= weight;
            stimulusReturn = Stimulus;
            Console.WriteLine("Stimulus = " + Stimulus);
            return Stimulus;
        }

        public double Neurone(List<double> Enter)
        {
            double Result = 0;
            for (int i = 0; i < Enter.Count; i++)
            {
                Result += Enter[i];
            }

            result = Result;
            Console.WriteLine("Result = " + result);
            return Result;
        }

        public void Correction(bool CorrectionNeeded, double goodValor)
        {
            if (CorrectionNeeded == true)
            {
                while (Synapse(goodValor) != goodValor)
                {
                    Random r = new Random();
                    if (stimulusReturn - goodValor < 0)
                    {
                        weight += -(r.Next(0, (int)Math.Abs((int)(stimulusReturn - (goodValor * 10000)) + 0.00001f)) / 100);
                    }
                    else
                    {
                        weight += +(r.Next(0, (int)Math.Abs((int)(stimulusReturn - (goodValor * 10000)) + 0.00001f)) / 100);
                    }
                }
            }
            else
            {
                Random r = new Random();
                weight += r.Next(mutation[0] - (mutation[1] / 4), mutation[1] - (mutation[1] / 4)) * ((stimulusReturn - goodValor) / 100000);
            }

            Console.WriteLine("weight = " + weight);
        }
    }
}
