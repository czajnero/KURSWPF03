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

namespace KursWPF03
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        void Odejmowanie(int x1, int x2)
        {
            MessageBox.Show((x1 - x2).ToString());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        int a, b, c;

        private void BT_Dodawanie_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);
            c = a + b;
            MessageBox.Show(c.ToString());
        }

        private void BT_Odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);
            Odejmowanie(a,b);
        }
    }
}
