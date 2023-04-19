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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Tutorial.Views.Tutorial24ViewV2.CustomControls
{

    public class SideMenuItem : ListBoxItem
    {

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register(
                nameof(Header), 
                typeof(string), 
                typeof(SideMenuItem), 
                new PropertyMetadata(null));


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


        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(
                nameof(Image), 
                typeof(ImageSource), 
                typeof(SideMenuItem), 
                new PropertyMetadata(null));


        public Stretch Stretch
        {
            get { return (Stretch)GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }

        public static readonly DependencyProperty StretchProperty =
            DependencyProperty.Register(
                nameof(Stretch), 
                typeof(Stretch), 
                typeof(SideMenuItem), 
                new PropertyMetadata(null));



        static SideMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SideMenuItem), new FrameworkPropertyMetadata(typeof(SideMenuItem)));
        }
    }
}
