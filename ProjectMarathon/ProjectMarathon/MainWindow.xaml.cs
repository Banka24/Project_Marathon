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
using System.Timers;
using System.Windows.Threading;

namespace ProjectMarathon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime eventTime = new DateTime(2023, 12, 31, 10, 0, 0);
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeUntilEvent = eventTime - DateTime.Now;
            lblTimeUntilEvent.Text = $"{timeUntilEvent.Days} дней {timeUntilEvent.Hours} часов и {timeUntilEvent.Minutes} минут до старта марафона!";
        }

        private void RunnerButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new RunnerPage());
        }

        private void SponsorRunnerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InfoButtonButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
