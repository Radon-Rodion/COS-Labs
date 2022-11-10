using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СhanceApproach
{
    internal class HarmonicSignalGenerator : ISignalGenerator
    {
        double _amplitude;
        double _frequency;
        double _phase;

        public HarmonicSignalGenerator(double amplitude, double frequency, double phase)
        {
            _amplitude = amplitude;
            _frequency = frequency;
            _phase = phase;
        }

        public double[] GenerateSignalPoints(int N, int M)
        {
            double[] res = new double[M];
            double currentPhase = _phase;

            for(int i = 0; i < M; i++)
            {
                res[i] = _amplitude * Math.Sin(currentPhase);
                currentPhase += 2 * Math.PI * _frequency / N;
            }

            return res;
        }
    }
}
