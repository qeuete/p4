using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp1.hotelDataSet1TableAdapters;



namespace WpfApp1
{
    public partial class BookingTableDS : Page
    {
        ViewBookingRoomDSTableAdapter bkview = new ViewBookingRoomDSTableAdapter();
        public BookingTableDS()
        {
            InitializeComponent();
            BookingViewDS.ItemsSource = bkview.GetData();
            FioCbx.ItemsSource = bkview.GetData();
            FioCbx.DisplayMemberPath = "fio";
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            BookingViewDS.ItemsSource = bkview.SearchByFio(SearchTxt.Text);
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SearchTxt.Text = null;
            BookingViewDS.ItemsSource = bkview.GetData();
        }
        private void Cbx_SelectionChanged(object sender, RoutedEventArgs e)
        {
            SearchTxt.Text = null;
            string Fio = (FioCbx.SelectedItem as DataRowView)["fio"].ToString();
            BookingViewDS.ItemsSource = bkview.FilterByFio(Fio);
        }
    }
}

