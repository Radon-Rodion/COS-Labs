using COS3.Algorythms;
using COS3.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СhanceApproach;

namespace COS_Lab3
{
    public class TaskViewModel
    {
        public double[] OrigSignalPoints { get; private set; }
        public string SignalSpectr { get; private set; }
        public double[] ResultSignalPoints { get; private set; }
        public double[] ResultSignaPointsWithoutPhase { get; private set; }

        public TaskViewModel(ISignalGenerator signalGenerator, int removeHarmonicsFrom = -1, int removeHarmonicsTo = -1)
        {
            OrigSignalPoints = signalGenerator.GenerateSignalPoints(GlobalConfigs.Configs.N);
            var xK = FurjeTransformer.Straight(OrigSignalPoints);
            var aK = xK.Select(x => Math.Sqrt(x.im * x.im + x.re * x.re)).ToArray();
            var fiK = xK.Select(x => Math.Atan(x.re / x.im) - Math.PI).ToArray();

            if(removeHarmonicsFrom != -1 && removeHarmonicsTo != -1)
            {
                for(int i = removeHarmonicsFrom; i <= removeHarmonicsTo; i++)
                {
                    aK[i] = 0;
                    fiK[i] = 0;
                }
            }

            var SignalSpectrSB = new StringBuilder();
            SignalSpectrSB.Append("R = ");
            SignalSpectrSB.AppendLine(String.Join("; ", Enumerable.Range(0, GlobalConfigs.Configs.N - 1).Select(i => i.ToString("D2")).Take(25)));
            SignalSpectrSB.Append("Are = ");
            SignalSpectrSB.AppendLine(String.Join("; ", xK.Select(x => x.re.ToString("0.##")).Take(30)));
            SignalSpectrSB.Append("Aim = ");
            SignalSpectrSB.AppendLine(String.Join("; ", xK.Select(x => x.im.ToString("0.##")).Take(30)));
            SignalSpectrSB.Append("A = ");
            SignalSpectrSB.AppendLine(String.Join("; ", aK.Select(a => a.ToString("0.##")).Take(30)));
            SignalSpectrSB.Append("fi = ");
            SignalSpectrSB.AppendLine(String.Join("; ", fiK.Select(fi => fi.ToString("0.##")).Take(30)));
            SignalSpectr = SignalSpectrSB.ToString();

            ResultSignalPoints = FurjeTransformer.Inversed(aK, fiK);
            ResultSignaPointsWithoutPhase = FurjeTransformer.Inversed(aK, new double[GlobalConfigs.Configs.N]);
        }
    }
}
