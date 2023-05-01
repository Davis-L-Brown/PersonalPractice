using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for Tutorial26.xaml
    /// </summary>
    public partial class Tutorial26 : Window
    {
        public Tutorial26()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;
            Excel.Range oRng;
            try
            {
                /// start excel and get application object
                oXL = new Excel.Application();
                oXL.Visible = true;

                /// get a new workbook
                oWB = (Excel.Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel.Worksheet)oWB.ActiveSheet;

                /// add table headers going cell by cell
                oSheet.Cells[1, 1] = "First Name";
                oSheet.Cells[1, 2] = "Last Name";
                oSheet.Cells[1, 3] = "Full Name";
                oSheet.Cells[1, 4] = "Salary";
            }
            catch(Exception ex) 
            {
                
            }
        }
    }
}
