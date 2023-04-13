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

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial9.xaml
    /// </summary>
    public partial class Tutorial9 : Window
    {
        public Tutorial9()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            ///MessageBox has a lot of overloads
            ///MessageBox.Show("Could not open file", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            ///the message box button gives greater functionality to the return of the message box
            MessageBoxResult result = MessageBox.Show("Could not open file", "Error!", MessageBoxButton.YesNo, MessageBoxImage.Error);

            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Yes";
               
            }
            else
            {
                tbInfo.Text = "No";
            }
        }
    }
}
