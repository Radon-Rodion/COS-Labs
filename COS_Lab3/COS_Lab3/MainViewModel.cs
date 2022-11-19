using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS_Lab3
{
    public class MainViewModel
    {
        public MainViewModel(TaskViewModel task2, TaskViewModel task3, TaskViewModel task45)
        {
            Orig2 = getListWithDataPoints(task2.OrigSignalPoints);
            Res2 = getListWithDataPoints(task2.ResultSignalPoints);
            Orig3 = getListWithDataPoints(task3.OrigSignalPoints);
            Res3 = getListWithDataPoints(task3.OrigSignalPoints);
            Res3WithoutPhases = getListWithDataPoints(task3.ResultSignaPointsWithoutPhase);
            Orig45 = getListWithDataPoints(task45.OrigSignalPoints);
            Res45 = getListWithDataPoints(task45.ResultSignalPoints);
        }

        private IList<DataPoint> getListWithDataPoints(double[] values)
        {
            var listWithDataPoints = new List<DataPoint>();
            for (int i = 0; i < values.Length; i++)
            {
                listWithDataPoints.Add(new DataPoint(i+1, values[i]));
            }
            return listWithDataPoints;
        }

        public IList<DataPoint> Orig2 { get; private set; }
        public IList<DataPoint> Res2 { get; private set; }
        public IList<DataPoint> Orig3 { get; private set; }
        public IList<DataPoint> Res3 { get; private set; }
        public IList<DataPoint> Res3WithoutPhases { get; private set; }
        public IList<DataPoint> Orig45 { get; private set; }
        public IList<DataPoint> Res45 { get; private set; }
    }
}
