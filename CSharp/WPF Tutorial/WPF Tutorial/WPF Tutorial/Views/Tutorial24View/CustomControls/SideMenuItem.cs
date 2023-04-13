using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Tutorial.Views.Tutorial24View.CustomControls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WPF_Tutorial.Views.Tutorial24View.CustomControls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WPF_Tutorial.Views.Tutorial24View.CustomControls;assembly=WPF_Tutorial.Views.Tutorial24View.CustomControls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:SideMenuItem/>
    ///
    /// </summary>
    public class SideMenuItem : MenuItem
    {



        public HorizontalAlignment HeaderHAlignment
        {
            get { return (HorizontalAlignment)GetValue(HeaderHAlignmentProperty); }
            set { SetValue(HeaderHAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HeaderHAlignmentProperty =
            DependencyProperty.Register(
                nameof(HeaderHAlignment), 
                typeof(HorizontalAlignment), 
                typeof(SideMenuItem), 
                new PropertyMetadata(null));



        public VerticalAlignment HeaderVAlignment
        {
            get { return (VerticalAlignment)GetValue(HeaderVAlignmentProperty); }
            set { SetValue(HeaderVAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HeaderVAlignmentProperty =
            DependencyProperty.Register(
                nameof(HeaderVAlignment), 
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
