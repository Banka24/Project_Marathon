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
    /// Логика взаимодействия для BMRPage.xaml
    /// </summary>
    public partial class BMRPage : Page
    {
        public BMRPage()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Rost.Text) || string.IsNullOrWhiteSpace(Ves.Text) || string.IsNullOrWhiteSpace(Age.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double a = Convert.ToDouble(Rost.Text);
            double b = Convert.ToDouble(Ves.Text);
            int age = Convert.ToInt32(Age.Text);

            double bmr = 0;
            if (Male.IsChecked.Value)
            {
                // Формула для мужчин
                bmr = 88.362 + (13.397 * b) + (4.799 * a) - (5.677 * age);
            }
            else if (Female.IsChecked.Value)
            {
                // Формула для женщин
                bmr = 447.593 + (9.247 * b) + (3.098 * a) - (4.330 * age);
            }

            // Вывод результата
            Result.Text = $"{bmr:F2} ккал/сутки (ежедневно тратится колорий)";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new InfoPage());
        }
    }
}
