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

namespace WPF_Tutorial.Views.Tutorial24View.CustomControls
{
    public class ListBoxSideMenuItem : ListBoxItem
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
                typeof(ListBoxSideMenuItem), 
                new PropertyMetadata(null));


        public HorizontalAlignment lbHeaderHAlignment
        {
            get { return (HorizontalAlignment)GetValue(lbHeaderHAlignmentProperty); }
            set { SetValue(lbHeaderHAlignmentProperty, value); }
        }

        public static readonly DependencyProperty lbHeaderHAlignmentProperty =
            DependencyProperty.Register(
                nameof(lbHeaderHAlignment),
                typeof(HorizontalAlignment),
                typeof(SideMenuItem),
                new PropertyMetadata(null));


        public VerticalAlignment lbHeaderVAlignment
        {
            get { return (VerticalAlignment)GetValue(lbHeaderVAlignmentProperty); }
            set { SetValue(lbHeaderVAlignmentProperty, value); }
        }

        public static readonly DependencyProperty lbHeaderVAlignmentProperty =
            DependencyProperty.Register(
                nameof(lbHeaderVAlignment),
                typeof(VerticalAlignment),
                typeof(SideMenuItem),
                new PropertyMetadata(null));


        /// <summary>
        /// lbImage source for the pictoral menu item 
        /// </summary>
        public ImageSource lbImage
        {
            get { return (ImageSource)GetValue(lbImageProperty); }
            set { SetValue(lbImageProperty, value); }
        }

        public static readonly DependencyProperty lbImageProperty =
            DependencyProperty.Register(
                nameof(lbImage),
                typeof(ImageSource),
                typeof(PictoralSideMenuItem),
                new PropertyMetadata(null));


        /// <summary>
        /// lbStretch for the lbImage in the pictoral menu item
        /// </summary>
        public Stretch lbStretch
        {
            get { return (Stretch)GetValue(lbStretchProperty); }
            set { SetValue(lbStretchProperty, value); }
        }

        public static readonly DependencyProperty lbStretchProperty =
            DependencyProperty.Register(
                nameof(lbStretch),
                typeof(Stretch),
                typeof(PictoralSideMenuItem),
                new PropertyMetadata(null));


        public Uri lbNavUri
        {
            get { return (Uri)GetValue(lbNavUriProperty); }
            set { SetValue(lbNavUriProperty, value); }
        }

        public static readonly DependencyProperty lbNavUriProperty =
            DependencyProperty.Register(
                nameof(lbNavUri),
                typeof(Uri),
                typeof(SideMenuItem),
                new PropertyMetadata(null));


        static ListBoxSideMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ListBoxSideMenuItem), new FrameworkPropertyMetadata(typeof(ListBoxSideMenuItem)));
        }
    }
}
