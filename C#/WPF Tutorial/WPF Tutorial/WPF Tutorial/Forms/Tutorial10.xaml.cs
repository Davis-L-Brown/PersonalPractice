using Microsoft.Win32;
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
    /// Interaction logic for Tutorial10.xaml
    /// </summary>
    public partial class Tutorial10 : Window
    {
        public Tutorial10()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            ///filter only .cs files
            fileDialog.Filter = "C# Source Files | *.cs";
            ///set the default directory
            fileDialog.InitialDirectory = "C:\\temp";
            ///give dialog window a title
            fileDialog.Title = "Please pick a cs source file(s)";
            ///allow multiple selections
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if (success == true) 
            {
                string path = fileDialog.FileName;
                string fileName = fileDialog.SafeFileName;
                tbInfo.Text = path;
            }
            else
            {

            }
        }
    }
}
