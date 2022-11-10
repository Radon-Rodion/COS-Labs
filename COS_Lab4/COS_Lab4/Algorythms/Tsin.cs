using COS3.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS3.Algorythms
{
    internal class Tsin
    {
        private static double[]? _sinValues = null;
        private static double[] sinValues
        {
            get
            {
                if (_sinValues is null)
                {
                    _sinValues = new double[GlobalConfigs.Configs.N];
                    for (int i = 0; i < GlobalConfigs.Configs.N; i++)
                    {
                        _sinValues[i] = GlobalConfigs.Configs.A * Math.Sin(2 * Math.PI * i / GlobalConfigs.Configs.N);
                    }
                }
                return _sinValues;
            }
        }
        public double this[int index]
        {
            get
            {
                return sinValues[index % GlobalConfigs.Configs.N];
            }
        }
    }
}
