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

namespace WpfApp1
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

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = System.Convert.ToInt32(this.N.Text);
                int K = System.Convert.ToInt32(this.K.Text);
                double phase = System.Convert.ToDouble(this.Phase.Text);
                if (K < 0 || K >= N) throw new ApplicationException("Invalid argument K");

                var statsGen = new SignalStatisticsCalculator(K, N, new HarmonicSignalGenerator(1, 1, 0));
                var statsGenWithPhase = new SignalStatisticsCalculator(K, N, new HarmonicSignalGenerator(1, 1, phase));

                this.DataContext = new MainViewModel(statsGen.GenerateAndCalculate(), statsGenWithPhase.GenerateAndCalculate(), K);

            } catch (Exception ex)
            {
                string messageBoxText = $"Ошибка! {ex.Message}";
                string caption = "Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;

                MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
        }
    }
}
