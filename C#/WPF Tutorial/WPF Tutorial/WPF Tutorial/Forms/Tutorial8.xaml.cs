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
    /// Interaction logic for Tutorial8.xaml
    /// </summary>
    public partial class Tutorial8 : Window, INotifyPropertyChanged
    {
        public Tutorial8()
        {
            ///sets the data context to this file
            DataContext = this;
            InitializeComponent();
        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set
            {
                boundText = value;
                ///need to define a datacontext to link this property to the gui element
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText")); ///sent to its own function
                OnPropertyChanged();
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Set From Code";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
