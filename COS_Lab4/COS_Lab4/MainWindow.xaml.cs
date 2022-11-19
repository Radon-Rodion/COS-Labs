using COS_Lab4.Smooth;
using COS3.Algorythms;
using COS3.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using СhanceApproach;

namespace COS_Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var generator = new SpecialSignalGenerator();
            var OrigSignalPoints = generator.GenerateSignalPoints(GlobalConfigs.Configs.N);
            var xK = FurjeTransformer.Straight(OrigSignalPoints);
            var aK = xK.Select(x => Math.Sqrt(x.im * x.im + x.re * x.re)).ToArray();
            var fiK = xK.Select(x => Math.Atan(x.im / x.re)).ToArray();

            var SignalSpectrSB = new StringBuilder();
            SignalSpectrSB.Append("R = ");
            SignalSpectrSB.AppendLine(String.Join("; ", Enumerable.Range(0, GlobalConfigs.Configs.N - 1).Select(i => i.ToString("D2")).Take(25)));
            SignalSpectrSB.Append("Are = ");
            SignalSpectrSB.AppendLine(String.Join("; ", xK.Select(x => x.re.ToString("0.##")).Take(30)));
            SignalSpectrSB.Append("Aim = ");
            SignalSpectrSB.AppendLine(String.Join("; ", xK.Select(x => x.im.ToString("0.##")).Take(30)));
            SignalSpectrSB.Append("A = ");
            SignalSpectrSB.AppendLine(String.Join("; ", aK.Select(a => (a * 2).ToString("0.##")).Take(30)));
            SignalSpectrSB.Append("fi = ");
            SignalSpectrSB.AppendLine(String.Join("; ", fiK.Select(fi => fi.ToString("0.##")).Take(30)));
            origSpectr.Text = SignalSpectrSB.ToString();

            var taskMedium = new TaskViewModel(OrigSignalPoints, new AverageSmoother(7));
            middleSpectr.Text = taskMedium.ToString();
            var taskParabola = new TaskViewModel(OrigSignalPoints, new ParabolicSmoother());
            parabolaSpectr.Text = taskParabola.ToString();
            var taskMedian = new TaskViewModel(OrigSignalPoints, new MedianFilterSmoother(9));
            medianSpectr.Text = taskMedian.ToString();

            this.DataContext = new MainViewModel(OrigSignalPoints, taskMedium, taskParabola, taskMedian);
        }
    }
}
