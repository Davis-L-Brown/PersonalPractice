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

        private int[] fakeYresults
        {
            get
            {
                return Enumerable.Range(0, 10).ToArray();
            }
        }

        public SeriesCollection SeriesCollection { get; set; }

        public string[] BarLabels { get; set; }

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

            BarLabels = new[] { "Values 1", "values 2", "values 3", "values 4" };
            Formatter = value => value.ToString("N");
            DataContext = this;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("{0}", fakeXresults);
        }
    }
}
