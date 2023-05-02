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
using Windows = System.Windows.Forms;
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

                /// Format A1:D1 as bold, vertical alignment center
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                /// create an array to multiple values at once
                string[,] saNames = new string[5, 2];

                saNames[0, 0] = "John";
                saNames[0, 1] = "Smith";
                saNames[1, 0] = "Tom";
                saNames[1, 1] = "Brown";
                saNames[2, 0] = "Sue";
                saNames[2, 1] = "Thomas";
                saNames[3, 0] = "Jane";
                saNames[3, 1] = "Jones";
                saNames[4, 0] = "Adam";
                saNames[4, 1] = "Johnson";

                /// fill A2:B6 with an array of values (First and Last Names)
                oSheet.get_Range("A2", "B6").Value2 = saNames;

                /// Fill c2:c6 with a relative formula (=A2 & " " & B2)
                oRng = oSheet.get_Range("C2", "C6");
                oRng.Formula = "=A2 & \" \" & B2";

                /// Fill D2:D6 with a formula (=RAND()*100000) and apply format
                oRng = oSheet.get_Range("D2", "D6");
                oRng.Formula = "=RAND()*100000";
                oRng.NumberFormat = "$0.00";

                /// Autofit columns A:D
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();

                /// Manipulate a variable number of columns for quarterly sales data
                DisplayQuarterlySales(oSheet);
            }
            catch(Exception ex) 
            {
                
            }
        }

        private void DisplayQuarterlySales(Excel.Worksheet oWS)
        {
            Excel._Workbook oWB;
            Excel.Series oSeries;
            Excel.Range oResizeRange;
            Excel._Chart oChart;
            String sMsg;
            int iNumQtrs;

            /// determine how many quarters to display data for
            for (iNumQtrs = 4; iNumQtrs >= 2; iNumQtrs--)
            {
                sMsg = "Enter sales data for ";
                sMsg = string.Concat(sMsg, iNumQtrs);
                sMsg = string.Concat(sMsg, " quarter(s)?");
                Windows.DialogResult iret = Windows.MessageBox.Show(
                    sMsg, 
                    "Quarterly Sales?", 
                    Windows.MessageBoxButtons.YesNo);
                if(iret == Windows.DialogResult.Yes)
                {
                    break;
                }
            }

            sMsg = "Displaying data for ";
            sMsg = String.Concat(sMsg, iNumQtrs);
            sMsg = String.Concat(sMsg, " quarter(s).");

            MessageBox.Show(sMsg, "Quarterly Sales");

            /// starting at E1, fill headers for the numbers of columns selected
            oResizeRange = oWS.get_Range("E1", "E1").get_Resize(Missing.Value, iNumQtrs);
            oResizeRange.Formula = "=\"Q\" & COLUMN()-4 & CHAR(10) & \"Sales\"";
        }
    }
}
