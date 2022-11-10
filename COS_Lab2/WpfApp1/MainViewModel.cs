using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class MainViewModel
    {
        public MainViewModel(StatisticsResultModel model, StatisticsResultModel modelWithPhase, int k)
        {
            this.Title = "Digital Signals Processing Lab 2";

            NonNormalizedD = getListWithDataPoints(model.NonNormalizedD, k);
            NormalizedD = getListWithDataPoints(model.NormalizedD, k);
            Amplitude = getListWithDataPoints(model.Amplitude, k);
            NonNormalizedDWithPhase = getListWithDataPoints(modelWithPhase.NonNormalizedD, k);
            NormalizedDWithPhase = getListWithDataPoints(modelWithPhase.NormalizedD, k);
            AmplitudeWithPhase = getListWithDataPoints(modelWithPhase.Amplitude, k);
        }

        private IList<DataPoint> getListWithDataPoints(double[] values, int k)
        {
            var listWithDataPoints = new List<DataPoint>();
            for(int i=0; i<values.Length; i++)
            {
                listWithDataPoints.Add(new DataPoint(i+k, values[i]));
            }
            return listWithDataPoints;
        }

        public string Title { get; private set; }

        public IList<DataPoint> NonNormalizedD { get; private set; }
        public IList<DataPoint> NormalizedD { get; private set; }
        public IList<DataPoint> Amplitude { get; private set; }
        public IList<DataPoint> NonNormalizedDWithPhase { get; private set; }
        public IList<DataPoint> NormalizedDWithPhase { get; private set; }
        public IList<DataPoint> AmplitudeWithPhase { get; private set; }
    }
}
