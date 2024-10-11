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
            ChangeBack.Click += ChangeBack_Click;
            Info.Click += Info_Click;
            Close.Click += Close_Click;
            ChangeBack2.Click += ChangeBack_Click;
            Info2.Click += Info_Click;
            Close2.Click += Close_Click;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Имя: Влад   Возраст: 18");
        }

        private void ChangeBack_Click(object sender, RoutedEventArgs e)
        {
            Win.Background = Brushes.DarkSeaGreen;
        }
    }
}
