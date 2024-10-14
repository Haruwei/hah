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

namespace Second
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

        public partial class MainWindow : Window
        {
        private SolidColorBrush _brushColor;
        private double Brushka;

        public MainWindow()
        {
            InitializeComponent();
            _brushColor = new SolidColorBrush(Colors.Black);
            Brushka = 5;
            DrawArea.DefaultDrawingAttributes.Color = Colors.Black;
            DrawArea.DefaultDrawingAttributes.Width = Brushka;
            DrawArea.DefaultDrawingAttributes.Height = Brushka;
        }

        private void СменаЦвета(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ColorPicker.SelectedItem is ComboBoxItem selectedItem)
            {
                var colorName = selectedItem.Tag.ToString();
                _brushColor = (SolidColorBrush)new BrushConverter().ConvertFromString(colorName);
                DrawArea.DefaultDrawingAttributes.Color = _brushColor.Color;
            }
        }

        private void РазмерКисти(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Brushka = BrushSizeSlider.Value;
            DrawArea.DefaultDrawingAttributes.Width = Brushka;
            DrawArea.DefaultDrawingAttributes.Height = Brushka;
        }

        private void Проверка_режима(object sender, RoutedEventArgs e)
        {
            if (DrawMode.IsChecked == true)
            {
                DrawArea.EditingMode = InkCanvasEditingMode.Ink;
            }
            else if (EditMode.IsChecked == true)
            {
                DrawArea.EditingMode = InkCanvasEditingMode.Select;
            }
            else if (DeleteMode.IsChecked == true)
            {
                DrawArea.EditingMode = InkCanvasEditingMode.EraseByPoint;
            }
        }
    }
    }