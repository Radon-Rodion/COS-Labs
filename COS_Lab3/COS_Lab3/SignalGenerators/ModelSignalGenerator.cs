using COS3.Algorythms;
using COS3.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СhanceApproach;

namespace COS_Lab3.SignalGenerators
{
    public class ModelSignalGenerator : ISignalGenerator
    {
        Random _random;
        Tsin _tsin;
        int _N;

        public ModelSignalGenerator()
        {
            _random = new Random();
            _N = GlobalConfigs.Configs.N;
            _tsin = new Tsin();
        }

        public double[] GenerateSignalPoints(int NPoints)
        {
            double[] res = new double[NPoints];
            double b1 = _random.NextDouble();
            double b2 = 5.714d * b1;

            for (int i = 0; i < _N; i++)
            {
                double highFreqPart = 0;
                foreach (int j in Enumerable.Range(50, 70))
                {
                    highFreqPart += Math.Sign(_random.NextDouble() - 0.5d) * _tsin[i * j];
                }
                res[i] = b1 * _tsin[i] + b2 * highFreqPart;
            }

            return res;
        }
    }
}
