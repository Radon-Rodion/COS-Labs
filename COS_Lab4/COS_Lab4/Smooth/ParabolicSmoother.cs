using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS_Lab4.Smooth
{
    public class ParabolicSmoother : ISmoother
    {
        int[] _koeffs = new int[7] { 5, -30, 75, 131, 75, -30, 5};
        double multiplyer = 1 / 231d;
        public double[] Smooth(double[] signal)
        {
            double[] result = new double[signal.Length];
            for (int i = 0; i < signal.Length; i++)
            {
                double val = 0;
                for (int j = 0; j < 7; j++)
                {
                    val += _koeffs[j] * signal[(i + j - 3 + signal.Length) % signal.Length];
                }
                result[i] = val * multiplyer;
            }
            return result;
        }
    }
}
