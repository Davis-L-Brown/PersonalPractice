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
using WPF_Tutorial.Properties;

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial21.xaml
    /// </summary>
    public partial class Tutorial21 : Window
    {
        public static event PropertyChangedEventHandler? PropertyChanged;

        private bool darkmode;
        public bool Darkmode 
        { 
            get { return darkmode; } 
            set { darkmode = value; OnPropertyChanged(); } 
        }
        
        public Tutorial21()
        {
            ///check initial darkmode user setting
            Darkmode = WPF_Tutorial.Properties.Settings.Default.DarkMode;
            InitializeComponent();
            ///////////////////////////////////////////////////////////////////
            ///Based on the way we set the foreground and background in this/// 
            ///  exmaple, the components must be initialized before we can  ///
            ///call InitialDarkMode() and change the color of the foreground///
            ///                   and background.                           ///
            ///////////////////////////////////////////////////////////////////
            //////set window state to match dark mode or light mode
            InitialDarkMode();
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// function to set window to dark mode or light mode
        /// </summary>
        private void InitialDarkMode()
        {
            if (WPF_Tutorial.Properties.Settings.Default.DarkMode)
            {
                this.Background = Brushes.Black;
                this.description.Foreground = Brushes.LightGray;
                this.Code.Foreground = Brushes.LightGray;
                this.rdbtnDarkMode.IsChecked = true;
            }
        }

        private void miDarkModeEnabled(object sender, RoutedEventArgs e)
        {
            if (Darkmode) 
            { 
                this.Background = Brushes.White;
                this.description.Foreground = Brushes.Black;
                this.Code.Foreground = Brushes.Black;
                this.rdbtnDarkMode.IsChecked = false;
            }
            else
            {
                this.Background = Brushes.Black;
                this.description.Foreground = Brushes.LightGray;
                this.Code.Foreground = Brushes.LightGray;
                this.rdbtnDarkMode.IsChecked = true;
            }
            Darkmode = !Darkmode;
            ///write the user settings config dark mode to the new local darkmode value
            WPF_Tutorial.Properties.Settings.Default.DarkMode = Darkmode;
            WPF_Tutorial.Properties.Settings.Default.Save();
        }
    }
}
