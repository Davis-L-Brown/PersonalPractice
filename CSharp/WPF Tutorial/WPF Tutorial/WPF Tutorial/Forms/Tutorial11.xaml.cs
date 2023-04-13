using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
/// giving winforms packages an alias
using WinForms = System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial11.xaml
    /// </summary>
    public partial class Tutorial11 : Window
    {
        public Tutorial11()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            ///this is a dialog from the WinForms package
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            dialog.InitialDirectory = "F:\\Dev\\asdf";
            WinForms.DialogResult result = dialog.ShowDialog();
            ///this can create a lot of  ambiguity, may need to specify the difference between
            ///winforms and WPF ocntrols
            ///we can create an alias for winforms packages in the using statement
            if (result == WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
            }
            else
            {

            }
        }
    }
}
