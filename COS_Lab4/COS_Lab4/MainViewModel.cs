using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS_Lab4
{
    internal class MainViewModel
    {
        public MainViewModel(double[] OrigSignalPoints, TaskViewModel taskMiddle, TaskViewModel taskParabola, TaskViewModel taskMedian)
        {
            Orig = getListWithDataPoints(OrigSignalPoints);
            Middle = getListWithDataPoints(taskMiddle.SmoothedSignalPoints);
            Parabola = getListWithDataPoints(taskParabola.SmoothedSignalPoints);
            Median = getListWithDataPoints(taskMedian.SmoothedSignalPoints);
            
        }

        private IList<DataPoint> getListWithDataPoints(double[] values)
        {
            var listWithDataPoints = new List<DataPoint>();
            for (int i = 0; i < values.Length; i++)
            {
                listWithDataPoints.Add(new DataPoint(i + 1, values[i]));
            }
            return listWithDataPoints;
        }

        public IList<DataPoint> Orig { get; private set; }
        public IList<DataPoint> Middle { get; private set; }
        public IList<DataPoint> Parabola { get; private set; }
        public IList<DataPoint> Median { get; private set; }
        
    }
}
