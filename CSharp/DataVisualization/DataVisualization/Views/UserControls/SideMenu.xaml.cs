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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataVisualization.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    [ContentProperty("SideMenuItems")]
    public partial class SideMenu : UserControl
    {

        public ObservableCollection<DependencyObject> SideMenuItems
        {
            get { return (ObservableCollection<DependencyObject>)GetValue(SideMenuItemsProperty); }
            set { SetValue(SideMenuItemsProperty, value); }
        }

        internal static readonly DependencyProperty SideMenuItemsProperty = DependencyProperty.Register(
            nameof(SideMenuItems), 
            typeof(ObservableCollection<DependencyObject>), 
            typeof(SideMenu));

        public SideMenu()
        {
            SetCurrentValue(SideMenuItemsProperty, new ObservableCollection<DependencyObject>());
            InitializeComponent();
        }

        

    }
}
