﻿///
/// https://www.youtube.com/watch?v=d1PqVmmFMSQ
/// tutorial on how to make reuseable custom user controls
///
/// "sunglasses emoji transparent" by pngwing.com
/// https://www.pngwing.com/en/free-png-zwkqf/download
///


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

namespace WPF_Tutorial.Views.Tutorial19View
{
    /// <summary>
    /// Interaction logic for TierCard.xaml
    /// </summary>
    public partial class TierCard : UserControl
    {

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(object), typeof(TierCard),
                new PropertyMetadata(string.Empty));

        public object Header
        {
            get { return (object)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); } 
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(TierCard),
                new PropertyMetadata(string.Empty));

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(Brush), typeof(TierCard),
                new PropertyMetadata(Brushes.Transparent));

        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public static readonly RoutedEvent JoinClickEvent = EventManager.RegisterRoutedEvent(nameof(JoinClick), 
            RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TierCard));

        public event RoutedEventHandler JoinClick
        {
            add { AddHandler(JoinClickEvent, value); }
            remove { RemoveHandler(JoinClickEvent, value); }
        }


        public TierCard()
        {
            InitializeComponent();
        }

        private void OnJoinClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(JoinClickEvent));
        }
    }
}
