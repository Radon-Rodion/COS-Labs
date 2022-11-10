using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СhanceApproach
{
    internal class PolyharmonicRandomSignalGenerator : ISignalGenerator
    {
        double[] _phases;
        double[] _amplitudes;
        Random _random;
        

        public PolyharmonicRandomSignalGenerator(double[] phases, double[] amplitudes)
        {
            _phases = phases;
            _amplitudes = amplitudes;
            _random = new Random();
        }
        public double[] GenerateSignalPoints(int NPoints)
        {
            double[][] pointsFromSeparateSignals = new double[30][];
            for(int j = 0; j < 30; j++)
            {
                var separateSignalGenerator = new HarmonicSignalGenerator(_amplitudes[_random.Next(_amplitudes.Length)], j, _phases[_random.Next(_phases.Length)]);
                pointsFromSeparateSignals[j] = separateSignalGenerator.GenerateSignalPoints(NPoints);
            }
            double[] res = new double[NPoints];
            for(int i=0; i<NPoints; i++)
            {
                res[i] = 0;
                for(int j=0; j<30; j++)
                {
                    res[i] += pointsFromSeparateSignals[j][i];
                }
            }
            return res;
        }
    }
}
