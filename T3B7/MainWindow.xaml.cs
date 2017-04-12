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

namespace T3B7
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string op;
        StringBuilder number1 = new StringBuilder();
        StringBuilder number2 = new StringBuilder();
        
        public MainWindow()
        {
            InitializeComponent();

            division.IsEnabled = false;
            multiplikation.IsEnabled = false;
            subtraktion.IsEnabled = false;
            addition.IsEnabled = false;
            istGleich.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button klick = (Button)sender;

            if (op == null)
            {
                division.IsEnabled = true;
                multiplikation.IsEnabled = true;
                subtraktion.IsEnabled = true;
                addition.IsEnabled = true;
                number1.Append(klick.Content);
                if (klick.Content == komma.Content)
                    komma.IsEnabled = false;
                label.Content = number1.ToString();

            }
            else if (op != null)
            {
                number2.Append(klick.Content);
                if (klick.Content == komma.Content)
                    komma.IsEnabled = false;
                if (number2 != null)
                    istGleich.IsEnabled = true;
                label.Content = $"{number1.ToString()} {op} {number2.ToString()}";
            }
        }

        private void Button_Operator(object sender, RoutedEventArgs e)
        {
            Button opKlick = (Button)sender;

            op = opKlick.Content.ToString();
            komma.IsEnabled = true;
            label.Content = $"{number1.ToString()} {op}";
        }

        private void Button_Ergebnis(object sender, RoutedEventArgs e)
        {
            Button ergebnisKlick = (Button)sender;
            double ergebnis = 0;
            string n1 = number1.ToString();
            string n2 = number2.ToString();

            switch (op)
            {
                case "+":
                    ergebnis = Convert.ToDouble(n1) + Convert.ToDouble(n2);
                    label.Content = ergebnis;
                    number1.Clear();
                    number2.Clear();
                    op = null;
                    division.IsEnabled = false;
                    multiplikation.IsEnabled = false;
                    subtraktion.IsEnabled = false;
                    addition.IsEnabled = false;
                    istGleich.IsEnabled = false;
                    komma.IsEnabled = true;
                    break;
                case "-":
                    ergebnis = Convert.ToDouble(n1) - Convert.ToDouble(n2);
                    label.Content = ergebnis;
                    number1.Clear();
                    number2.Clear();
                    op = null;
                    division.IsEnabled = false;
                    multiplikation.IsEnabled = false;
                    subtraktion.IsEnabled = false;
                    addition.IsEnabled = false;
                    istGleich.IsEnabled = false;
                    komma.IsEnabled = true;
                    break;
                case "*":
                    ergebnis = Convert.ToDouble(n1) * Convert.ToDouble(n2);
                    label.Content = ergebnis;
                    number1.Clear();
                    number2.Clear();
                    op = null;
                    division.IsEnabled = false;
                    multiplikation.IsEnabled = false;
                    subtraktion.IsEnabled = false;
                    addition.IsEnabled = false;
                    istGleich.IsEnabled = false;
                    komma.IsEnabled = true;
                    break;
                case "/":
                    ergebnis = Convert.ToDouble(n1) / Convert.ToDouble(n2);
                    label.Content = ergebnis;
                    number1.Clear();
                    number2.Clear();
                    op = null;
                    division.IsEnabled = false;
                    multiplikation.IsEnabled = false;
                    subtraktion.IsEnabled = false;
                    addition.IsEnabled = false;
                    istGleich.IsEnabled = false;
                    komma.IsEnabled = true;
                    break;
            }
        }
    }
}
