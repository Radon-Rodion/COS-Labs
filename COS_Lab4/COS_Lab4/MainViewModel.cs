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
            _origBackup = getListWithDataPoints(OrigSignalPoints);
            _middleBackup = getListWithDataPoints(taskMiddle.SmoothedSignalPoints);
            _parabolaBackup = getListWithDataPoints(taskParabola.SmoothedSignalPoints);
            _medianBackup = getListWithDataPoints(taskMedian.SmoothedSignalPoints);
            
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

        public void DrawGraphics(bool showOriginal, bool showMiddle, bool showParabola, bool showMedian)
        {
            Orig = showOriginal ? _origBackup : new List<DataPoint>();
            Middle = showMiddle ? _middleBackup : new List<DataPoint>();
            Parabola = showParabola ? _parabolaBackup : new List<DataPoint>();
            Median = showMedian ? _medianBackup : new List<DataPoint>();

        }

        private IList<DataPoint> _origBackup;
        private IList<DataPoint> _middleBackup;
        private IList<DataPoint> _parabolaBackup;
        private IList<DataPoint> _medianBackup;

        public IList<DataPoint> Orig { get; private set; }
        public IList<DataPoint> Middle { get; private set; }
        public IList<DataPoint> Parabola { get; private set; }
        public IList<DataPoint> Median { get; private set; }
        
    }
}
