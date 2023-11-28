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
    /// Логика взаимодействия для BMIPage.xaml
    /// </summary>
    public partial class BMIPage : Page
    {
        public BMIPage()
        {
            InitializeComponent();
        }

        private void ResultBMI(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Rost.Text, out double a) && double.TryParse(Ves.Text, out double b))
            {
                double bmi = CalculateBMI(a, b);
                DisplayBMIResult(bmi);
                UpdateProgressBar(bmi);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения роста и веса.");
            }
        }

        private void UpdateProgressBar(double bmi)
        {
            bmiProgressBar.Value = bmi;

            if (bmi < 18.5)
            {
                // Недостаточный (Оранжевый цвет)
                SetProgressBarColor(Colors.Orange);
            }
            else if (bmi < 24.9)
            {
                // Здоровый (зеленый)
                SetProgressBarColor(Colors.Green);
            }
            else if (bmi < 29.9)
            {
                // Избыточный (желтый)
                SetProgressBarColor(Colors.Yellow);
            }
            else
            {
                // Ожирение (красный)
                SetProgressBarColor(Colors.Red);
            }
        }

        private void SetProgressBarColor(Color color)
        {
            SolidColorBrush brush = new SolidColorBrush(color);
            bmiProgressBar.Foreground = brush;
        }

        private double CalculateBMI(double a, double b)
        {
            return b / Math.Pow(a / 100, 2);
        }

        private void DisplayBMIResult(double bmi)
        {
            string gender = Male.IsChecked == true ? "мужской" : "женский";
            string result;
            if (bmi < 18.5)
            {
                result = "недостаточная масса тела";
            }
            else if (bmi < 24.9)
            {
                result = "нормальная масса тела";
            }
            else if (bmi < 29.9)
            {
                result = "избыточная масса тела";
            }
            else
            {
                result = "ожирение";
            }
            Result.Text = $"Ваш BMI: {bmi:F2}\nПол: {gender}\nСостояние: {result}";
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new NewMainWindow());
        }
    }
}
