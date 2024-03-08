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

namespace WpfApp24
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Enum1
        {
            yellow,
            green,
            gray,
            black,
        }
        public MainWindow()
        {
            InitializeComponent();
             List<string> colors = new List<string>()
             {
                 "yellow",
                 "green",
                 "gray",
                 "black",
                 "white",
                 "red",
                 "orange",
             };
            Colors.ItemsSource = colors;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Colors.Text == Enum1.green.ToString())
            {
                MyColor.Foreground = Brushes.Green;
            }
            else if (Colors.Text == Enum1.yellow.ToString())
            {
                MyColor.Foreground = Brushes.Yellow;
            }
            else if (Colors.Text == Enum1.gray.ToString())
            {
                MyColor.Foreground = Brushes.Gray;
            }
            else if (Colors.Text == Enum1.black.ToString())
            {
                MyColor.Foreground = Brushes.Black;
            }
            else
            {
                MessageBox.Show("В разработке");
            }
        }

        private void Colors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
