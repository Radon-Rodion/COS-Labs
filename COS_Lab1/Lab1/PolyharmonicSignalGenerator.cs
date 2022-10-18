using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СhanceApproach
{
    internal class PolyharmonicSignalGenerator : ISignalGenerator
    {
        (double amplitude, double frequency, double phase)[] _paramGroups;
        

        public PolyharmonicSignalGenerator((double amplitude, double frequency, double phase)[] paramGroups)
        {
            _paramGroups = paramGroups;
        }
        public double[] GenerateSignalPoints(int NPoints)
        {
            double[][] pointsFromSeparateSignals = new double[_paramGroups.Length][];
            for(int i = 0; i < _paramGroups.Length; i++)
            {
                var separateSignalGenerator = new HarmonicSignalGenerator(_paramGroups[i].amplitude, _paramGroups[i].frequency, _paramGroups[i].phase);
                pointsFromSeparateSignals[i] = separateSignalGenerator.GenerateSignalPoints(NPoints);
            }
            double[] res = new double[NPoints];
            for(int i=0; i<NPoints; i++)
            {
                res[i] = 0;
                for(int j=0; j<_paramGroups.Length; j++)
                {
                    res[i] += pointsFromSeparateSignals[j][i];
                }
            }
            return res;
        }
    }
}
