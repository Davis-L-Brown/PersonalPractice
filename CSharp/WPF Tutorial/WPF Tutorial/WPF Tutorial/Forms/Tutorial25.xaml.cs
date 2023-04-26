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

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial25.xaml
    /// </summary>
    public partial class Tutorial25 : Window
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        private string filepath;

        public string FilePath
        {
            get { return filepath; }
            set { filepath = value; OnPropertyChanged(); }
        }

        public Tutorial25()
        {
            FilePath = Properties.Settings.Default.tutorial25link;
            filepath = "ABC";
            InitializeComponent();
        }

        public void OnPropertyChanged([CallerMemberName] string memberName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }


    }
}
