using COS_Lab3.SignalGenerators;
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

namespace COS_Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ISignalGenerator _task45SignalGenerator = new ModelSignalGenerator();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var task2 = new TaskViewModel(new HarmonicSignalGenerator(20, 10, 0));
            task2Spectr.Text = task2.SignalSpectr;

            var phases = new double[] { Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, Math.PI * 3 / 4, Math.PI };
            var amplitudes = new double[] { 1, 3, 4, 10, 11, 14, 17 };
            var task3 = new TaskViewModel(new PolyharmonicRandomSignalGenerator(phases, amplitudes));
            task3Spectr.Text = task3.SignalSpectr;

            int harmonicFrom = freqFrom.Text!="0" ? (int)Math.Ceiling(Convert.ToDouble(freqFrom.Text)) : 0;
            int harmonicTo = freqTo.Text != "0" ? (int)Math.Ceiling(Convert.ToDouble(freqTo.Text)) : GlobalConfigs.Configs.N-1;
            var task45 = new TaskViewModel(_task45SignalGenerator, harmonicFrom, harmonicTo);
            task45Spectr.Text = task45.SignalSpectr;
            this.DataContext = new MainViewModel(task2, task3, task45);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _task45SignalGenerator = new ModelSignalGenerator();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            _task45SignalGenerator = new RealSignalGenerator();
        }
    }
}
