using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Tutorial.Views.Tutorial24ViewV2.CustomControls;

namespace WPF_Tutorial.Views.Tutorial24ViewV2.UserControls
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    [ContentProperty("SideMenuItems")]
    public partial class SideMenu : UserControl
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        public SideMenuItem SelectedItem
        {
            get { return (SideMenuItem)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
                nameof(SelectedItem), 
                typeof(SideMenuItem), 
                typeof(SideMenu), 
                new PropertyMetadata(null));



        public ObservableCollection<DependencyObject> SideMenuItems
        {
            get { return (ObservableCollection<DependencyObject>)GetValue(SideMenuItemsProperty); }
            set { SetValue(SideMenuItemsProperty, value); }
        }

        public static readonly DependencyProperty SideMenuItemsProperty =
            DependencyProperty.Register(
                nameof(SideMenuItems), 
                typeof(ObservableCollection<DependencyObject>), 
                typeof(SideMenu));



        public SideMenu()
        {
            SetCurrentValue(SideMenuItemsProperty, new ObservableCollection<DependencyObject>());
            InitializeComponent();   
        }

        
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void lbItemContainer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbItemContainer.SelectedItems != null && lbItemContainer.SelectedItems.Count > 0) 
            {
                SelectedItem = (SideMenuItem)lbItemContainer.SelectedItems[0]; 
            }
            foreach (SideMenuItem item in lbItemContainer.Items)
            {
                item.Background = Brushes.Transparent;
            }
            if (SelectedItem != null)
            {
                SelectedItem.Background = Brushes.Gray;
            }
        }
    }
}
