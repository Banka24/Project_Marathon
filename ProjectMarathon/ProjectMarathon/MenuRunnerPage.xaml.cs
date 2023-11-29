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
    /// Логика взаимодействия для MenuRunnerPage.xaml
    /// </summary>
    public partial class MenuRunnerPage : Page
    {
        public MenuRunnerPage()
        {
            InitializeComponent();
        }



        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            ContactInfo taskWindow = new ContactInfo();
            taskWindow.Show();           
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            Navigation1.Navigate(new LoginFormPage());
        }

        private void sponsor_Click(object sender, RoutedEventArgs e)
        {
            Navigation1.Navigate(new MySponsorPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            Navigation1.Navigate(new NewMainWindow());
        }
    }
}
