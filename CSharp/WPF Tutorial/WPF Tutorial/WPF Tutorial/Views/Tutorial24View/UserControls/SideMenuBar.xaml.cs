using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.Xml;
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
using WPF_Tutorial.Views.Tutorial24View.CustomControls;

namespace WPF_Tutorial.Views.Tutorial24View.UserControls
{
    /// <summary>
    /// Interaction logic for SideMenuBar.xaml
    /// </summary>
    [ContentProperty("SideMenuItems")]
    public partial class SideMenuBar : UserControl
    {

        /// <summary>
        /// reference to the System.Windows.Controls selectionModeEnum
        /// </summary>
        public SelectionMode SelectionMode
        {
            get { return (SelectionMode)GetValue(SelectionModeProperty); }
            set { SetValue(SelectionModeProperty, value); }
        }

        public static readonly DependencyProperty SelectionModeProperty =
            DependencyProperty.Register(nameof(SelectionMode), 
                typeof(SelectionMode), 
                typeof(SideMenuBar), 
                new PropertyMetadata(null));


        /// <summary>
        /// collection of side menu items (whatever those items may be)
        /// </summary>
        public ObservableCollection<DependencyObject> SideMenuItems
        {
            get { return (ObservableCollection<DependencyObject>)GetValue(SideMenuItemsProperty); }
            set { SetValue(SideMenuItemsProperty, value); }
        }

        internal static readonly DependencyProperty SideMenuItemsProperty =
            DependencyProperty.Register(nameof(SideMenuItems), 
                typeof(ObservableCollection<DependencyObject>), 
                typeof(SideMenuBar));



        public SideMenuBar()
        {
            SetCurrentValue(SideMenuItemsProperty, new ObservableCollection<DependencyObject>());
            InitializeComponent();
        }
    }
}
