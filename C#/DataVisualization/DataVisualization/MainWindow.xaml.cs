using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using DataVisualization.Interfaces;
using LiveCharts;
using LiveCharts.Wpf;

namespace DataVisualization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<ICity> cities;
        public ObservableCollection<ICity> Cities
        {
            get { return cities; }
            set { cities = value; }
        }

        private static readonly Random rand = new Random();

        ///private CartesianChart _dataChart { get; set; }
        
        private int[] fakeXresults
        {
            get
            {
                return Enumerable.Range(0, 10).ToArray();
            }
        }

        public SeriesCollection _seriesCollection { get; set; }

        private ColumnSeries _series { get; set; }

        private List<double> fakeYresults
        {
            get
            {
                List<double> result = new List<double>();
                //int[] results = Enumerable.Range(0, 4).ToArray();
                
                //for (int i=0; i < results.Length; i++)
                //{
                //    fakeYresults[i] = (int)(double)results[i];
                //}
                for (int i = 0; i < 4; i++)
                {
                    result.Add(rand.NextDouble() * 20);
                }

                return result;
            }
        }
        
        public string[] Labels { get; set; }

        public Func<double, string> Formatter { get; set; }

        public MainWindow(CartesianChart dataChart, SeriesCollection sCollection, ColumnSeries cSeries, ObservableCollection<ICity> cities)
        {
            DataContext = this;
            //_dataChart = dataChart;
            _seriesCollection = sCollection;
            _series = cSeries;
            Cities = cities;
            InitializeComponent();

            Labels = new[] { "Jan", "Feb", "Mar", "Apr" };
            Formatter = value => value.ToString("C");
            DataContext = this;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            /// research how to add to a c# dictionary
            /// double[] generatedResults = fakeYresults;
            List<double> generatedResults = fakeYresults;
            _seriesCollection.Add(new LineSeries
            {
                Title = "RandomResults",
                Values = new ChartValues<double>(generatedResults)
            });
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
