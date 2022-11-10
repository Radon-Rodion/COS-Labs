using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СhanceApproach;

namespace COS_Lab3.SignalGenerators
{
    public class RealSignalGenerator : ISignalGenerator
    {
        private double[] _lightningFrequencies = new double[11] { 4.75, 5.00, 5.25, 5.50, 5.65, 6.00, 6.20, 6.50, 6.75, 7.45, 7.75};
        private double[] _lightningAmplitudes = new double[11] { 0.08, 0.27, 0.26, 0.36, 0.41, 1.12, 0.49, 0.3, 0.12, 0.56, 2.23};
        public double[] GenerateSignalPoints(int NPoints)
        {
            double[][] pointsFromSeparateSignals = new double[11][];
            for (int j = 0; j < 11; j++)
            {
                var separateSignalGenerator = new HarmonicSignalGenerator(_lightningAmplitudes[j], _lightningFrequencies[j], 0);
                pointsFromSeparateSignals[j] = separateSignalGenerator.GenerateSignalPoints(NPoints);
            }
            double[] res = new double[NPoints];
            for (int i = 0; i < NPoints; i++)
            {
                res[i] = 0;
                for (int j = 0; j < 11; j++)
                {
                    res[i] += pointsFromSeparateSignals[j][i];
                }
            }
            return res;
        }
    }
}
