using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataVisualization.Views.CustomControls
{
    public class SideMenuItem : MenuItem
    {

        public HorizontalAlignment HeaderHAlignment
        {
            get { return (HorizontalAlignment)GetValue(HeaderHAlignmentProperty); }
            set { SetValue(HeaderHAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HeaderHAlignmentProperty =
            DependencyProperty.Register(nameof(HeaderHAlignment), 
                typeof(HorizontalAlignment), 
                typeof(SideMenuItem), 
                new PropertyMetadata(null));


        public VerticalAlignment HeaderVAlignment
        {
            get { return (VerticalAlignment)GetValue(HeaderVAlignmentProperty); }
            set { SetValue(HeaderVAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HeaderVAlignmentProperty =
            DependencyProperty.Register(nameof(HeaderVAlignment), 
                typeof(VerticalAlignment), 
                typeof(SideMenuItem), 
                new PropertyMetadata(null));


        public Uri NavUri
        {
            get { return (Uri)GetValue(NavUriProperty); }
            set { SetValue(NavUriProperty, value); }
        }

        public static readonly DependencyProperty NavUriProperty =
            DependencyProperty.Register(
                nameof(NavUri), 
                typeof(Uri), 
                typeof(SideMenuItem), 
                new PropertyMetadata(null));


        static SideMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SideMenuItem), new FrameworkPropertyMetadata(typeof(SideMenuItem)));
        }
    }

    public class StringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
