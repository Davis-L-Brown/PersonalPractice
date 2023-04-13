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
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    [ContentProperty("MenuItems")]
    public partial class MenuBar : UserControl
    {

        /// this idea came from stack overflow:
        /// https://stackoverflow.com/questions/14871180/adding-items-to-a-menu-in-a-usercontrol
        /// and this youtube video
        /// https://www.youtube.com/watch?v=d1PqVmmFMSQ
        /// allows me to add different menu items to this user control in different windows
        /// EG: main window has File, settings
        ///     whereas the File>About page may have other menu items.

        public ObservableCollection<DependencyObject> MenuItems
        {
            get { return (ObservableCollection<DependencyObject>)GetValue(MenuItemsProperty); }
            set { SetValue(MenuItemsProperty, value); }
        }

        internal static readonly DependencyProperty MenuItemsProperty = DependencyProperty.Register(
            nameof(MenuItems),
            typeof(ObservableCollection<DependencyObject>), 
            typeof(MenuBar));
    

        public MenuBar()
        {
            SetCurrentValue(MenuItemsProperty, new ObservableCollection<DependencyObject>());
            InitializeComponent();
        }
    }
}
