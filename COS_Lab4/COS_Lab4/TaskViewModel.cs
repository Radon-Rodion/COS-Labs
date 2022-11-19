using COS_Lab4.Smooth;
using COS3.Algorythms;
using COS3.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СhanceApproach;

namespace COS_Lab4
{
    internal class TaskViewModel
    {
        public double[] OrigSignalPoints { get; private set; }
        public string SignalSpectr { get; private set; }
        public double[] SmoothedSignalPoints { get; private set; }
        public string SmoothedSignalSpectr { get; private set; }

        public TaskViewModel(double[] signalPoints, ISmoother smoother)
        {
            OrigSignalPoints = signalPoints;

            SmoothedSignalPoints = smoother.Smooth(OrigSignalPoints);
            var xK = FurjeTransformer.Straight(SmoothedSignalPoints);
            var aK = xK.Select(x => Math.Sqrt(x.im * x.im + x.re * x.re)).ToArray();
            var fiK = xK.Select(x => Math.Atan(x.im / x.re)).ToArray();

            var SmoothedSignalSpectrSB = new StringBuilder();
            SmoothedSignalSpectrSB.Append("R = ");
            SmoothedSignalSpectrSB.AppendLine(String.Join("; ", Enumerable.Range(0, GlobalConfigs.Configs.N - 1).Select(i => i.ToString("D2")).Take(25)));
            SmoothedSignalSpectrSB.Append("Are = ");
            SmoothedSignalSpectrSB.AppendLine(String.Join("; ", xK.Select(x => x.re.ToString("0.##")).Take(30)));
            SmoothedSignalSpectrSB.Append("Aim = ");
            SmoothedSignalSpectrSB.AppendLine(String.Join("; ", xK.Select(x => x.im.ToString("0.##")).Take(30)));
            SmoothedSignalSpectrSB.Append("A = ");
            SmoothedSignalSpectrSB.AppendLine(String.Join("; ", aK.Select(a => (a * 2).ToString("0.##")).Take(30)));
            SmoothedSignalSpectrSB.Append("fi = ");
            SmoothedSignalSpectrSB.AppendLine(String.Join("; ", fiK.Select(fi => fi.ToString("0.##")).Take(30)));
            SmoothedSignalSpectr = SmoothedSignalSpectrSB.ToString();
        }
    }
}
