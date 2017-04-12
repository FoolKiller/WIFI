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

namespace T3B4
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random c = new Random();
            int col = c.Next(0, 5);
            Random r = new Random();
            int row = r.Next(0, 7);

            Grid.SetColumn(schiff1Vorne, col);
            Grid.SetRow(schiff1Vorne, row);
            Grid.SetColumn(schiff1Mitte, (col + 1));
            Grid.SetRow(schiff1Mitte, row);
            Grid.SetColumn(schiff1Hinten, (col + 2));
            Grid.SetRow(schiff1Hinten, row);            
        }

        private void kadusch(object sender, RoutedEventArgs e)
        {
            Button klick = (Button)sender;
            // Version 1
            var toggleButtonPosition1 = klick.TranslatePoint(new Point(0, 0), grid);
            var toggleButtonPosition2 = schiff1Vorne.TranslatePoint(new Point(0, 0), grid);
            var toggleButtonPosition3 = schiff1Mitte.TranslatePoint(new Point(0, 0), grid);
            var toggleButtonPosition4 = schiff1Hinten.TranslatePoint(new Point(0, 0), grid);

            if (toggleButtonPosition1 == toggleButtonPosition2)
            {
                klick.Content = "Vorne";
            }
            else if (toggleButtonPosition1 == toggleButtonPosition3)
            {
                klick.Content = "Mitte";
            }
            else if (toggleButtonPosition1 == toggleButtonPosition4)
            {
                klick.Content = "Hinten";
            }
            else
            {
                klick.Content = "Daneben";
            }
            // Ende Version 1
        }
    }
}
