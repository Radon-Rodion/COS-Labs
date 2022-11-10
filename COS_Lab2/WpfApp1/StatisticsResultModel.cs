using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class StatisticsResultModel
    {
        public double[] NonNormalizedD { get; set; }
        public double[] NormalizedD { get; set; }
        public double[] Amplitude { get; set; }

        public StatisticsResultModel(int size)
        {
            NonNormalizedD = new double[size];
            NormalizedD = new double[size];
            Amplitude = new double[size];
        }
    }
}
