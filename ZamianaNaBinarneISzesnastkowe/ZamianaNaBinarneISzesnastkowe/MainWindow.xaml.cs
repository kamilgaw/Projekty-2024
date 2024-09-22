using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zamiana_na_binarne
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a;
            if (int.TryParse(liczba.Text, out a))
            {
                string pomocnicza = "";
                while (a != 0)
                {
                    if (a % 2 == 0)
                    {
                        pomocnicza += "0";
                        a = a / 2;
                    }
                    if (a % 2 == 1)
                    {
                        pomocnicza += "1";
                        a--;
                        a = a / 2;
                    }
                }
                string wynik = "";
                for (int i = pomocnicza.Length - 1; i >= 0; i--)
                {
                    wynik += pomocnicza[i];
                }
                wypis.Content = wynik;
            }
            else
            {
                wypis.Content = "Nie podałeś liczby";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a;
            if (int.TryParse(liczba.Text, out a))
            {
                string pomocnicza = "";
                int reszta;
                while (a != 0)
                {
                    reszta = a % 16;
                    if (reszta == 10)
                        pomocnicza += "A";
                    if (reszta == 11)
                        pomocnicza += "B";
                    if (reszta == 12)
                        pomocnicza += "C";
                    if (reszta == 13)
                        pomocnicza += "D";
                    if (reszta == 14)
                        pomocnicza += "E";
                    if (reszta == 15)
                        pomocnicza += "F";
                    if (reszta != 10 && reszta != 11 && reszta != 12 && reszta != 13 && reszta != 14 && reszta != 15)
                        pomocnicza += Convert.ToString(reszta);
                    a = a / 16;
                }
                string wynik = "";
                for (int i = pomocnicza.Length - 1; i >= 0; i--)
                {
                    wynik += pomocnicza[i];
                }
                wypis16.Content = wynik;
            }
            else
            {
                wypis.Content = "Nie podałeś liczby";
            }
        }
    }
}