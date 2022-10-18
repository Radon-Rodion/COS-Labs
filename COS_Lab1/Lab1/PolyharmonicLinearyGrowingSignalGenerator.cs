using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СhanceApproach
{
    internal class PolyharmonicLinearyGrowingSignalGenerator : ISignalGenerator
    {
        (double amplitude, double frequency, double phase)[] _paramGroups;
        double _growthKoeff;


        public PolyharmonicLinearyGrowingSignalGenerator((double amplitude, double frequency, double phase)[] paramGroups, double growthKoeff)
        {
            _paramGroups = paramGroups;
            _growthKoeff = growthKoeff;
        }
        public double[] GenerateSignalPoints(int NPoints)
        {
            var currentParamGroups = new (double amplitude, double frequency, double phase)[_paramGroups.Length];
            Array.Copy(_paramGroups, currentParamGroups, _paramGroups.Length);

            double[][] pointsFromSeparateSignals = new double[_paramGroups.Length][];
            for (int i = 0; i < _paramGroups.Length; i++)
            {
                var separateSignalGenerator = new HarmonicLinearyGrowingSignalGenerator(_paramGroups[i].amplitude, _paramGroups[i].frequency, _paramGroups[i].phase, _growthKoeff);
                pointsFromSeparateSignals[i] = separateSignalGenerator.GenerateSignalPoints(NPoints);
            }
            double[] res = new double[NPoints];
            for (int i = 0; i < NPoints; i++)
            {
                res[i] = 0;
                for (int j = 0; j < _paramGroups.Length; j++)
                {
                    res[i] += pointsFromSeparateSignals[j][i];
                }
            }
            return res;
        }
    }
}
