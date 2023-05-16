using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

using Excel = Microsoft.Office.Interop.Excel;

namespace WPF_Tutorial.Forms
{
    /// <summary>
    /// Interaction logic for Tutorial27.xaml
    /// </summary>
    public partial class Tutorial27 : Window
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        private string MessageHolder = string.Empty;

        public string firstName
        {
            get { return (string)GetValue(firstNameProperty); }
            set { SetValue(firstNameProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty firstNameProperty =
            DependencyProperty.Register(
                nameof(firstName), 
                typeof(string), 
                typeof(Tutorial27), 
                new PropertyMetadata("First Name"));


        public string lastName
        {
            get { return (string)GetValue(lastNameProperty); }
            set { SetValue(lastNameProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty lastNameProperty =
            DependencyProperty.Register(
                nameof(lastName), 
                typeof(string), 
                typeof(Tutorial27), 
                new PropertyMetadata("Last Name"));


        public string email
        {
            get { return (string)GetValue(emailProperty); }
            set { SetValue(emailProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty emailProperty =
            DependencyProperty.Register(
                nameof(email), 
                typeof(string), 
                typeof(Tutorial27), 
                new PropertyMetadata("Email@email.com"));


        public Dictionary<string, Customer> dCustomers
        {
            get { return (Dictionary<string, Customer>)GetValue(customersProperty); }
            set { SetValue(customersProperty, value); }
        }

        public static readonly DependencyProperty customersProperty =
            DependencyProperty.Register(
                nameof(dCustomers), 
                typeof(Dictionary<string, Customer>), 
                typeof(Tutorial27));


        public ObservableCollection<Customer> ocCustomers
        {
            get { return (ObservableCollection<Customer>)GetValue(ocCustomersProperty); }
            set { SetValue(ocCustomersProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty ocCustomersProperty =
            DependencyProperty.Register(
                nameof(ocCustomers), 
                typeof(ObservableCollection<Customer>), 
                typeof(Tutorial27));


        public Tutorial27()
        {
            DataContext = this;
            SetCurrentValue(customersProperty, new Dictionary<string, Customer>());
            SetCurrentValue(ocCustomersProperty, new ObservableCollection<Customer>());
            InitializeComponent();
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        private void tbGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender.GetType() == typeof(TextBox)) 
            {
                TextBox tb = (TextBox)sender;
                MessageHolder = tb.Text;
                tb.Text = "";
            }

        }

        private void tbLostKeyBoardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (sender.GetType() == typeof(TextBox) & String.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = MessageHolder;
            }
        }

        private void btnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(firstName) & !String.IsNullOrEmpty(lastName) & !String.IsNullOrEmpty(email))
                {
                    Customer custy = new Customer(firstName, lastName, email);
                    ocCustomers.Add(custy);
                    dCustomers.Add(String.Concat(firstName, " ", lastName), custy);
                }
                else
                {
                    Customer custy = new Customer();
                    ocCustomers.Add(custy);
                    dCustomers.Add(String.Concat(custy.FName, " ", custy.LName), custy);

                }
            }
            catch(Exception ex)
            {

            }

            firstName = "First Name";
            lastName = "Last Name";
            email = "Email@email.com";
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oWS;
            Excel.Range oR;
            try
            {
                oXL = new Excel.Application();
                oXL.Visible = true;

                oWB = (Excel.Workbook)(oXL.Workbooks.Add(Missing.Value));
                
            }
            catch(Exception ex) { }
        }

    }


    public class Customer
    {
        private string fName = "";
        public string FName {
            get { return fName; }
            set { fName = value; }
        }

        private string lName = "";
        public string LName 
        { 
            get { return lName; }
            set { lName = value; }
        }

        private string email = "";
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Customer()
        {
            FName = "John";
            LName = "Doe";
            Email = "John.Doe@gmail.com";
        }

        public Customer(string fName, string lName, string email)
        {
            FName = fName;
            LName = lName;
            Email = email;
        }
    }

}
