using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS_Lab4.Smooth
{
    public class AverageSmoother : ISmoother
    {
        private int _K;
        private int _m;
        public AverageSmoother(int K)
        {
            if (K % 2 == 0) throw new ArgumentException("K must be an odd number!");
            _K = K;
            _m = (K - 1) / 2;
        }
        public double[] Smooth(double[] signal)
        {
            double[] result = new double[signal.Length];
            for(int i = 0; i < signal.Length; i++)
            {
                double val = 0;
                for(int j = -_m; j <= _m; j++)
                {
                    val += signal[(i+j+signal.Length)%(signal.Length)];
                }
                result[i] = val / _K;
            }
            return result;
        }
    }
}
