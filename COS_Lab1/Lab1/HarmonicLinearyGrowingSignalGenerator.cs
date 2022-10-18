using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СhanceApproach
{
    internal class HarmonicLinearyGrowingSignalGenerator : ISignalGenerator
    {
        double _amplitude;
        double _frequency;
        double _phase;
        double _growthKoeff;

        public HarmonicLinearyGrowingSignalGenerator(double amplitude, double frequency, double phase, double growthKoeff)
        {
            _amplitude = amplitude;
            _frequency = frequency;
            _phase = phase;
            _growthKoeff = growthKoeff;
        }

        public double[] GenerateSignalPoints(int NPoints)
        {
            double currentAmplitude = _amplitude;
            double currentFrequency = _frequency;
            double currentPhase = _phase;

            double[] res = new double[NPoints];

            for (int i = 0; i < NPoints; i++)
            {
                res[i] = currentAmplitude * Math.Sin((2*Math.PI*currentFrequency*i/NPoints)+currentPhase);
                currentAmplitude *= _growthKoeff;
                currentFrequency *= _growthKoeff;
                currentPhase *= _growthKoeff;
            }

            return res;
        }
    }
}
