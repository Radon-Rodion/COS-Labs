using COS3.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS3.Algorythms
{
    public class FurjeTransformer
    {
        private int _N = GlobalConfigs.Configs.N;
        private int _A = GlobalConfigs.Configs.A;
        private Tsin _tsin = new Tsin();
        public double[] Straight(double[] x)
        {

        }

        public double[] Inversed(double[] x)
        {

        }

        private (double re, double im) countKoeffs(double[] x, int k)
        {
            double re = 0;
            double im = 0;

            int ss = 0;
            int sc = _N / 4;

            for(int i=0; i<_N; i++)
            {
                re += x[i] * _tsin[sc];
                im += x[i] * _tsin[ss];

                ss += k;
                sc += k;
                ss %= _N;
                sc %= _N;
            }

            return (re/(_N*_A), im/(_N*_A));
        }
    }
}
