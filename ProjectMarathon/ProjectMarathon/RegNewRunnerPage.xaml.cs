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
using Microsoft.Win32;

namespace ProjectMarathon
{
    /// <summary>
    /// Логика взаимодействия для RegNewRunnerPage.xaml
    /// </summary>
    public partial class RegNewRunnerPage : Page
    {
        public RegNewRunnerPage()
        {
            InitializeComponent();
        }

        private void ConfirmNewRunnerButton(object sender, RoutedEventArgs e)
        {
            NavigationPage.Navigate(new ConfirmNewRunnerPage());
        }

        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFileName = openFileDialog.FileName;
                imgPreview.Source = new BitmapImage(new Uri(selectedFileName));
                TextBoxFile.Text = System.IO.Path.GetFileName(selectedFileName);
            }
        }
    }
}
