using COS3.Algorythms;
using COS3.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СhanceApproach
{
    internal class SpecialSignalGenerator : ISignalGenerator
    {
        Random _random;
        Tsin _tsin;
        int _N;

        public SpecialSignalGenerator()
        {
            _random = new Random();
            _N = GlobalConfigs.Configs.N;
            _tsin = new Tsin();
        }

        public double[] GenerateSignalPoints(int NPoints)
        {
            double[] res = new double[NPoints];
            double b2 = _random.NextDouble();
            double b1 = 33.71d * b2;

            for(int i = 0; i<_N; i++)
            {
                double highFreqPart = 0;
                foreach(int j in Enumerable.Range(50, 70))
                {
                    highFreqPart += Math.Sign(_random.NextDouble() - 0.5d) * _tsin[i * j];
                }
                res[i] = b1 * _tsin[i] + b2 * highFreqPart;
            }

            return res;
        }
    }
}
