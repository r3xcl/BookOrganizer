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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BookOrganizer.Views
{

    public partial class SettingsWindow : Window
    {

        private DispatcherTimer timer = new DispatcherTimer();

 
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Timer();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Timer()
        {
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 1.0,
                To = 0.0,
                Duration = new Duration(TimeSpan.FromSeconds(0.4))
            };
            this.BeginAnimation(Window.OpacityProperty, animation);

            timer.Tick += new EventHandler(CloseWindow);
            timer.Interval = new TimeSpan(0,0,0,0,400);
            timer.Start();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
