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
    /// Interaction logic for Tutorial4.xaml
    /// </summary>
    public partial class Tutorial4 : Window
    {
        bool running = false;
        public Tutorial4()
        {
            InitializeComponent();

            //this will change the text when the window is compiled
            //tbHelloWorld.Text = "Hello World 2";
        }

        /// <summary>
        /// function to change the text of our text block when user clicks the run button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                //running = false;
                tbHelloWorld.Text = "Hello World";
                tbRunStatus.Text = "Stopped";
                btnRun.Content = "Run";
            }
            else
            {
                //running = true;
                tbHelloWorld.Text = "Hello World 2";
                tbRunStatus.Text = "Running";
                btnRun.Content = "Stop";
            }
            running = !running;
        }
    }
}
