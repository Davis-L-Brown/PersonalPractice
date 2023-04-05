using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using LiveCharts;
using LiveCharts.Wpf;
using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial20.xaml
    /// </summary>
    public partial class Tutorial20 : Window
    {

        public static event PropertyChangedEventHandler? PropertyChanged;

        public ISeries[] Series { get; set; }
            = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values=new double[] {2,1,3,5,3,4,6 },
                    Fill = null
                }
            };

        public ISeries[] Series2 { get; set; }
        = new ISeries[]
        {
            new ColumnSeries<double>
            {
                Name = "mary",
                Values = new double[] { 2, 5, 4 }
            },
            new ColumnSeries<double>{
                Name = "Ana",
                Values = new double[] {3,1,6}
            }
        };

        public LiveChartsCore.SkiaSharpView.Axis[] XAxes { get; set; }
        = {
            new LiveChartsCore.SkiaSharpView.Axis
            {
                Labels = new string[] {"Test 1", "Test 2", "Test 3"},
                LabelsRotation = 0,
                SeparatorsPaint = new SolidColorPaint(new SkiaSharp.SKColor(200,200,200)),
                SeparatorsAtCenter = false,
                TicksPaint = new SolidColorPaint(new SkiaSharp.SKColor(35,35,35)),
                TicksAtCenter = true
            }
        };

        private ChartValues<double> series3;

        public ChartValues<double> Series3 { 
            get
            {
                return series3;
            }
            set { series3 = value; OnPropertyChanged(); }
        }

        public Tutorial20()
        {
            DataContext = this;
            Series3 = new ChartValues<double>();
            InitializeComponent();
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Convertable(tbAdd.Text))
            {
                Series3.Add(double.Parse(tbAdd.Text));
            }
        }

        private bool Convertable(string value)
        {
            try { double.TryParse(value, out var result); return true; }
            catch { return false; }
        }
    }
}
