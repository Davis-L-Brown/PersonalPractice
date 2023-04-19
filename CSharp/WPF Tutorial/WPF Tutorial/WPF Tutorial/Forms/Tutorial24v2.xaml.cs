using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WPF_Tutorial.Views.Tutorial24ViewV2.CustomControls;

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial24v2.xaml
    /// </summary>
    public partial class Tutorial24v2 : Window
    {
        public Tutorial24v2()
        {
            DataContext = this;
            InitializeComponent();
        }
    }
}
