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

namespace Labra10T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int laskuritrucks = 0;
        int laskuricars = 0;
        public MainWindow()
        {
         
        }

        private void truckstxb_Click(object sender, RoutedEventArgs e)
        {
            laskuritrucks++;
            txttrucks.Text = laskuritrucks.ToString();
        }

        private void carstxb_Click(object sender, RoutedEventArgs e)
        {
            laskuricars++;
            txtcars.Text = laskuricars.ToString();
        }
    }
}
