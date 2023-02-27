using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SimpleInjector;
using DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

static class BootStrapper
{
    /// <summary>
    /// 
    /// </summary>
    [STAThread]
    static void Main()
    {
        var container = Bootstrap();

        // Any additional other configuration, e.g. of your desired MVVM toolkit.

        RunApplication(container);
    }

    private static Container Bootstrap()
    {
        // Create the container as usual.
        var container = new Container();

        // Register your types, for instance:
        //container.Register<IQueryProcessor, QueryProcessor>(Lifestyle.Singleton);
        //container.Register<IUserContext, WpfUserContext>();
        Chart dataChart = new Chart();
        container.RegisterInstance(typeof(Chart), dataChart);
        // Register your windows and view models:
        container.Register<MainWindow>();


        container.Verify();

        return container;
    }

    private static void RunApplication(Container container)
    {
        try
        {
            var app = new App();
            var mainWindow = container.GetInstance<MainWindow>();
            app.Run(mainWindow);
        }
        catch (Exception ex)
        {
            //Log the exception and exit
            Console.WriteLine(ex.Message);
        }
    }
}
