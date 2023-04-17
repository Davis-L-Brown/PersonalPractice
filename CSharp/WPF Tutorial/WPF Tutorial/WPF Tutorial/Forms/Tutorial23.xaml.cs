using Microsoft.VisualBasic.ApplicationServices;
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
using Typography.OpenFont.Tables;
using WPF_Tutorial.Views.Tutorial23View.Pages;

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial23.xaml
    /// </summary>
    public partial class Tutorial23 : Window
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        private Uri openPage;

        public Uri OpenPage
        {
            get { return openPage; }
            set { openPage = value; OnPropertyChanged(); }
        }

        public Tutorial23()
        {
            DataContext = this;
            OpenPage = new Uri("../Views/Tutorial23View/Pages/LandingPage.xaml", UriKind.Relative);
            InitializeComponent();
        }

        
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
