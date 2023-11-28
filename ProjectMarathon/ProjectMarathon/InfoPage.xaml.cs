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

namespace ProjectMarathon
{
    /// <summary>
    /// Логика взаимодействия для InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void Marathon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BMI_Click(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new BMIPage());
        }

        private void time_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Organizac_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BMR_Click(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new BMRPage());
        }
    }
}
