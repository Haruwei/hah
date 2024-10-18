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

namespace zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CheckInput_Click(object sender, RoutedEventArgs e)
        {
            string userInput = avava.Text;
            if (IsValidInput(userInput))
            {
                MessageBox.Show("Ввод не корректен", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                
                MessageBox.Show("Ввод корректен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private bool IsValidInput(string input)
        {
            return !string.IsNullOrEmpty(input) && (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^[A-Z][a-zA-Z]*$"));
        }
    }
}
