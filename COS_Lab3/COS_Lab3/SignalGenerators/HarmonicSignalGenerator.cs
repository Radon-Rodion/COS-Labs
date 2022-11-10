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

        public double[] GenerateSignalPoints(int NPoints)
        {
            double[] res = new double[NPoints];
            double currentPhase = _phase;

            for(int i = 0; i < NPoints; i++)
            {
                res[i] = _amplitude * Math.Cos(currentPhase);
                currentPhase += 2 * Math.PI * _frequency / NPoints;
            }

            return res;
        }
    }
}
