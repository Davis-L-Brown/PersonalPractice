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
using WPF_Tutorial.Forms;

namespace WPF_Tutorial
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

        private void miTutorial3_Click(object sender, RoutedEventArgs e)
        {
            Tutorial3 tutorial3Window = new Tutorial3();
            tutorial3Window.Show();
        }

        private void miTutorial4_Click(object sender, RoutedEventArgs e)
        {
            Tutorial4 tutorial4Window = new Tutorial4();
            tutorial4Window.Show();
        }

        private void miTutorial13_Click(object sender, RoutedEventArgs e)
        {
            Tutorial13 tutorial13Window = new Tutorial13();
            tutorial13Window.Show();
        }
    }
}
