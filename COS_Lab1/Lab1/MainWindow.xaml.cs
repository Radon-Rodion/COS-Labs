// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="BSUIR">
//   BSUIR
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace СhanceApproach
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using OxyPlot;

    using СhanceApproach.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const int pointsCount = 1024;
        private int task = 3;

        private void SetPhaseInputsfalse(bool areEnabled)
        {
            
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            TextBox[] phaseLabels = { this.Phase1, this.Phase2, this.Phase3, this.Phase4, this.Phase5 };
            var pointsByTask = new PointsByTask(pointsCount, phaseLabels);
            this.DataContext = new MainViewModel(pointsByTask[task]);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            task = 3;
            SetPhaseInputsfalse(false);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            task = 4;
            SetPhaseInputsfalse(false);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            task = 0;
            SetPhaseInputsfalse(false);
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            task = 1;
            SetPhaseInputsfalse(false);
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            task = 2;
            SetPhaseInputsfalse(false);
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            task = 5;
            SetPhaseInputsfalse(true);
        }
    }
}
