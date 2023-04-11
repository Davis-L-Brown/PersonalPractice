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
using System.Windows.Shapes;

namespace DataVisualization.Forms
{
    /// <summary>
    /// Interaction logic for CityAdder.xaml
    /// </summary>
    public partial class CityAdder : Window
    {
        public string CityName { get { return CityName; } set { CityName = value; } }
        public string Population { get { return Population; } set { Population = value; } }
        public CityAdder()
        {
            InitializeComponent();
        }
    }
}
