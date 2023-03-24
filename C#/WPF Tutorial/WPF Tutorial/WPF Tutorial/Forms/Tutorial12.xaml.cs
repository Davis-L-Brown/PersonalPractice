using System;
using System.Collections;
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

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial12.xaml
    /// </summary>
    public partial class Tutorial12 : Window
    {
        public Tutorial12()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntry.Items.Add(tbEntries.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Tomato, Tomato.
            //int selectedIndex = lvEntry.SelectedIndex;
            //lvEntry.Items.RemoveAt(selectedIndex);
            //object item = lvEntry.SelectedItem;
            //lvEntry.Items.Remove(item);
            var items = lvEntry.SelectedItems;
            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items?", "Sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                ///create an itterator so as not to break iteration/enumeration of lvEntry
                var itemList = new ArrayList(items);
                foreach(var item in itemList)
                {
                    lvEntry.Items.Remove(item);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntry.Items.Clear();
        }
    }
}
