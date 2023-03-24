using System;
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
    /// Interaction logic for Tutorial13.xaml
    /// </summary>
    public partial class Tutorial13 : Window
    {
        public Tutorial13()
        {
            //DataContext = this;
            //entries = new ObservableCollection<string>();
            InitializeComponent();
        }

        //private ObservableCollection<string> entries;
        //private ObservableCollection<string> Entries
        //{
        //    get { return entries; }
        //    set { entries = value; }
        //}

        ///// <summary>
        ///// Using a BINDING, this function adds what is added to the textbox when the user hits the Add button
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    Entries.Add(txtEntry.Text);
        //}

        ///// <summary>
        ///// Using a DIRECT REFERENCE, this function removes a selected list item when the user clicks the del button
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnDelete_Click(object sender, RoutedEventArgs e)
        //{
        //    string selectedItem = (string)lvEntries.SelectedItem;
        //    Entries.Remove(selectedItem);
        //}

        ///// <summary>
        ///// clears the entries list (and dynamically the list view) upon clicking the clr button
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnClear_Click(object sender, RoutedEventArgs e)
        //{
        //    Entries.Clear();
        //}
    }
}
