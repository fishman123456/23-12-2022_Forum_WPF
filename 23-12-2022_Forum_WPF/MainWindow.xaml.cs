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

namespace _23_12_2022_Forum_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

 

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           Background = new SolidColorBrush(Colors.Red);
            //  < Border BorderBrush = "Blue" BorderThickness = "2" CornerRadius = "6" > </ Border >
            Title = Red.Name;
            //Title = "RED";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Blue);
            Title = Blue.Name;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Background= new SolidColorBrush(Colors.Green); 
            Title = Green.Name;
        }
 

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Background = new SolidColorBrush(Colors.White);
            Title = "White";
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Colors.White);
            Title = "White";
        }
    }
}
//Набор_кнопок

// Разработать приложение содержащее набор кнопок, занимающих 2/3 ширины окна при любых его размерах.
// Каждая кнопка должна в качестве содержимого отображать название цвета и обладать наружным
// отступом равным 2. Также соответствующий цвет должен использоваться в качестве цвета переднего
// плана кнопки. Необходимо использовать следующий набор цветов: Navy, Blue, Aqua, Teal, Olive,
// Green, Lime, Yellow, Orange, Red, Maroon, Fuchsia, Purple, Black, Silver, Gray, White.
// Также при нажатию на кнопку, цвет формы должен меняться на выбранный,
// а в заголовке было бы написано "Теперь цвет формы Navy".