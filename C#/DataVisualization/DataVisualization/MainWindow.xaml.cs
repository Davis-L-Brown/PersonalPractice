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

using LiveCharts;
using LiveCharts.Wpf;

namespace DataVisualization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private int[] fakeXresults
        {
            get
            {
                return Enumerable.Range(0, 10).ToArray();
            }
        }

        private double[] fakeYresults
        {
            get
            {
                int[] results = Enumerable.Range(0, 4).ToArray();
                for (int i=0; i < results.Length; i++)
                {
                    fakeYresults[i] = (int)(double)results[i];
                }
                return fakeYresults;
            }
        }

        public SeriesCollection SeriesCollection { get; set; }

        public string[] Labels { get; set; }

        public Func<double, string> Formatter { get; set; }


        public MainWindow(CartesianChart dataChart)
        {
            CartesianChart _dataChart = dataChart;
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title= "Val1",
                    Values = new ChartValues<double> { 5, 10, 15, 20 }
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "val2",
                Values = new ChartValues<double> { 10, 15, 20, 25 }
            });

            SeriesCollection.Add(new LineSeries
            {
                Title = "FakeXResults",
                Values = new ChartValues<double> { 1, 2, 3, 4 }
            });

            Labels = new[] { "Jan", "Feb", "Mar", "Apr" };
            Formatter = value => value.ToString("C");
            DataContext = this;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            /// research how to add to a c# dictionary
            double[] generatedResults = fakeYresults;
            SeriesCollection.Add(new LineSeries
            {
                Title = "RandomResults",
                Values = new ChartValues<double> { }
            });
        }
    }
}
