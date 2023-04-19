using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Tutorial.Views.Tutorial23View.CustomControls
{
    public class NavButton : Button
    {
        

        public ImageSource imageSource
        {
            get { return (ImageSource)GetValue(imageSourceProperty); }
            set { SetValue(imageSourceProperty, value); }
        }

        public static readonly DependencyProperty imageSourceProperty =
            DependencyProperty.Register("imageSource", typeof(ImageSource), typeof(NavButton), new PropertyMetadata(null));


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(NavButton), new PropertyMetadata(null));


        public Uri NavUri
        {
            get { return (Uri)GetValue(NavUriProperty); }
            set { SetValue(NavUriProperty, value); }
        }

        public static readonly DependencyProperty NavUriProperty =
            DependencyProperty.Register("lbNavUri", typeof(Uri), typeof(NavButton), new PropertyMetadata(null));



        static NavButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavButton), new FrameworkPropertyMetadata(typeof(NavButton)));
        }
    }
}
