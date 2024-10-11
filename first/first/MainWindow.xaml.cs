using System;
using System.Collections.Generic;
using System.Linq;
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

namespace first
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DarkSeaGreen.Click += DarkSeaGreen_Click;
            Khaki.Click += Khaki_Click;
            DarkKhaki.Click += DarkKhaki_Click;
            Info.Click += Info_Click;
            Close.Click += Close_Click;
            Цвета.Click += DarkSeaGreen_Click;
            Инфа.Click += Info_Click;
            Закрыть.Click += Close_Click;
        }
        private void Вход(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                statusBarItem.Content = button.Name.ToString();
            }
        }

        private void Выход(object sender, MouseEventArgs e)
        {
            statusBarItem.Content = "";
        }
        private void ВходВПоле(object sender, MouseEventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                statusBarItem.Content = menuItem.Header.ToString();
            }
        }

        private void ВыходИзПоля(object sender, MouseEventArgs e)
        {
            statusBarItem.Content = "";
        }
        private void DarkKhaki_Click(object sender, RoutedEventArgs e)
        {
            Win.Background = Brushes.DarkKhaki;
        }

        private void Khaki_Click(object sender, RoutedEventArgs e)
        {
            Win.Background = Brushes.Khaki;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Имя: Влад   Возраст: 18");
        }

        private void DarkSeaGreen_Click(object sender, RoutedEventArgs e)
        {
            Win.Background = Brushes.DarkSeaGreen;
        }
    }
}
