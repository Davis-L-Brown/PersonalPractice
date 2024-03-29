﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using DataVisualization;
using DataVisualization.Interfaces;
using LiveCharts;
using LiveCharts.Wpf;
using SimpleInjector;

static class Program
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
        ObservableCollection<ICity> cities = new ObservableCollection<ICity>();
        container.RegisterInstance(typeof(ObservableCollection<ICity>), cities);


        CartesianChart dataChart = new CartesianChart();
        container.RegisterInstance(typeof(CartesianChart), dataChart);
        SeriesCollection sCollection = new SeriesCollection();
        container.RegisterInstance(typeof(SeriesCollection), sCollection);
        ColumnSeries cSeries = new ColumnSeries();
        container.RegisterInstance(typeof(ColumnSeries), cSeries);

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
