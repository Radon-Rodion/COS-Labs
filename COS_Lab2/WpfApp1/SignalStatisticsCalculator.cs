using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using СhanceApproach;

namespace WpfApp1
{
    internal class SignalStatisticsCalculator
    {
        private ISignalGenerator _signalGenerator;
        private int _K;
        private int _N;
        
        public SignalStatisticsCalculator(int k, int n, ISignalGenerator signalGenerator)
        {
            _signalGenerator = signalGenerator;
            _K = k;
            _N = n;
        }

        public StatisticsResultModel GenerateAndCalculate()
        {
            var result = new StatisticsResultModel(2*_N-_K);
            for(int m=_K; m<2*_N; m++)
            {
                double[] signalValues = _signalGenerator.GenerateSignalPoints(_N, m);
                result.NonNormalizedD[m - _K] = 0.707 - dNonNormalizedCalculate(signalValues, m);
                result.NormalizedD[m - _K] = 0.707 - dNormalizedCalculate(signalValues, m);
                result.Amplitude[m - _K] = 1 - amplitudeCalculate(signalValues, m);
            }
            return result;
        }

        private double dNonNormalizedCalculate(double[] xValues, int M)
        {
            return Math.Sqrt((xValues.Select(x => x * x).Sum()) / (M + 1));
        }

        private double dNormalizedCalculate(double[] xValues, int M)
        {
            return Math.Sqrt((xValues.Select(x => x * x).Sum()) / (M + 1) - Math.Pow(xValues.Sum() / (M + 1), 2));
        }

        private double amplitudeCalculate(double[] xValues, int M)
        {
            double reX = 0;
            double imX = 0;
            for(int i=0; i < M; i++)
            {
                reX += xValues[i] * Math.Cos(2 * Math.PI * i / M);
                imX += xValues[i] * Math.Sin(2 * Math.PI * i / M);
            }
            reX *= 2d/M; 
            imX *= -2d/M;
            return Math.Sqrt(reX*reX + imX*imX);
        }
    }
}
