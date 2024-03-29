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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ClinetsTable(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ClientsWindow();
        }
        private void RoomsTable(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new RoomsWindow();
        }
        private void BookingTable(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new BookingWindow();
        }
        private void BookingTableDS(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new BookingTableDS();
        }
    }
}
