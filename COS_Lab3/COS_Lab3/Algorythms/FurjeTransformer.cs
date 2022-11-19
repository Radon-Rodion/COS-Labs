using COS3.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS3.Algorythms
{
    public static class FurjeTransformer
    {
        private static int _N = GlobalConfigs.Configs.N;
        private static double _A = GlobalConfigs.Configs.A;
        private static Tsin _tsin = new Tsin();
        public static (double re, double im)[] Straight(double[] xn)
        {
            var xK = new (double re, double im)[xn.Length];
            for (int k=0; k<xn.Length; k++)
            {
                xK[k] = countKoeffs(xn, k, _N * _A);
            }
            return xK;
        }

        public static double[] Inversed(double[] a, double[] fi)
        {
            var res = new double[_N];
            for(int i=0; i<_N; i++)
            {
                double sum = 0d;
                for (int j = 0; j < _N/2; j++)
                {
                    sum += a[j]*2 * Math.Cos( (2 * Math.PI * i * j / _N) - fi[j]);
                }
                res[i] = sum;
            }
            return res;
        }

        private static (double re, double im) countKoeffs(double[] x, int k, double divider)
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

            return (re/(divider), im/(divider));
        }
    }
}
