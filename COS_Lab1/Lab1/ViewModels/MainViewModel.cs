namespace СhanceApproach.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;

    using OxyPlot;

    public class MainViewModel
    {
        public MainViewModel(double[][] pointsForGraphs)
        {
            this.Title = "Digital Signals Processing Lab 1";
            for(int i=0; i<5; i++)
            {
                this[i] = new List<DataPoint>();
            }

            for (int i = 0; i < pointsForGraphs.Length; i++)
            {
                for(int j=0; j<pointsForGraphs[i].Length; j++)
                {
                    this[i].Add(new DataPoint(j, pointsForGraphs[i][j]));
                }        
            }
        }

        public string Title { get; private set; }

        public IList<DataPoint> PointsFor1 { get; private set; }
        public IList<DataPoint> PointsFor2 { get; private set; }
        public IList<DataPoint> PointsFor3 { get; private set; }
        public IList<DataPoint> PointsFor4 { get; private set; }
        public IList<DataPoint> PointsFor5 { get; private set; }

        public IList<DataPoint> this[int index]
        {
            get {
                switch (index)
                {
                    case 0:
                        return PointsFor1;
                    case 1:
                        return PointsFor2;
                    case 2:
                        return PointsFor3;
                    case 3:
                        return PointsFor4;
                    case 4:
                        return PointsFor5;
                    default:
                        return null;
                }
            }
            private set
            {
                switch (index)
                {
                    case 0:
                        PointsFor1 = value;
                        break;
                    case 1:
                        PointsFor2 = value;
                        break;
                    case 2:
                        PointsFor3 = value;
                        break;
                    case 3:
                        PointsFor4 = value;
                        break;
                    case 4:
                        PointsFor5 = value;
                        break;
                }
            }
        }
    }
}