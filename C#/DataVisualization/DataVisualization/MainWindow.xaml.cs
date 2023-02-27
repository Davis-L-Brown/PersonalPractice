using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        public MainWindow(Chart dataChart)
        {
            Chart _dataChart = dataChart;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("{0}", fakeXresults);
        }
    }
}
