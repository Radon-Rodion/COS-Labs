using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS_Lab4.Smooth
{
    public class MedianFilterSmoother : ISmoother
    {
        private int _window;
        public MedianFilterSmoother(int window)
        {
            _window = window;
        }

        public double[] Smooth(double[] signal)
        {
            double[] result = new double[signal.Length];
            for(int i = 0; i < signal.Length; i++)
            {
                double[] subArr = new double[_window];
                for(int j = 0; j < _window; j++)
                {
                    subArr[j] = signal[(i+j-_window/2 + signal.Length)%signal.Length];
                }
                subArr = subArr.OrderBy(x => x).ToArray();
                result[i] = subArr[_window / 2];
            }
            return result;
        }
    }
}
