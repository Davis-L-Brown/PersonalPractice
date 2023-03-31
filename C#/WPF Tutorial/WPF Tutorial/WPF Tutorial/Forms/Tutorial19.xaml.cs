///
/// https://www.youtube.com/watch?v=d1PqVmmFMSQ
/// tutorial on how to make reuseable custom user controls
///
/// "sunglasses emoji transparent" by pngwing.com
/// https://www.pngwing.com/en/free-png-zwkqf/download
///

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

using Emoji.Wpf;

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial19.xaml
    /// </summary>
    public partial class Tutorial19 : Window
    {
        public Tutorial19()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Congratulations, you have joined the basic Tier.");
        }

        private void btnJoin_Pro(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have leveled up, you are a pro");
        }

        private void btnJoin_Enterprise(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Insert sunglasses emoji here");
        }
    }
}
