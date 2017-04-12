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

namespace T3B3
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

        private void gechkt(object sender, RoutedEventArgs e)
        {
            if (chkBox1.IsChecked == true && chkBox2.IsChecked == true)
            {
                wasIstGechkt.Content = $"Es sind {chkBox1.Content} und {chkBox2.Content} angehakt";
            }
            else if(chkBox1.IsChecked == true)
            {
                wasIstGechkt.Content = $"Es ist {chkBox1.Content} angehakt";
            }
            else if(chkBox2.IsChecked == true)
            {
                wasIstGechkt.Content = $"Es ist {chkBox2.Content} angehakt";
            }
            else
            {
                wasIstGechkt.Content = "Welche CheckBox ist gechkt";
            }            
        }
    }
}
