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

namespace T3B2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void istMarkiert(object sender, RoutedEventArgs e)
        {
            if(rButton1.IsChecked == true)
            {
                wasGedrueckt.Content = $"Es ist {rButton1.Content} gedrückt.";
                wasGedrueckt.Background = rButton1.Background;
                wasGedrueckt.FontSize = 20;
            }
            else if (rButton2.IsChecked == true)
            {
                wasGedrueckt.Content = $"Es ist {rButton2.Content} gedrückt.";
                wasGedrueckt.Background = rButton2.Background;
                wasGedrueckt.FontSize = 20;
            }
            else if (rButton3.IsChecked == true)
            {
                wasGedrueckt.Content = $"Es ist {rButton3.Content} gedrückt.";
                wasGedrueckt.Background = rButton3.Background;
                wasGedrueckt.FontSize = 20;
            }
        }
    }
}
