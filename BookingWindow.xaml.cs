using System.Linq;
using System.Windows.Controls;
using System.Windows;

namespace WpfApp1
{
    public partial class BookingWindow : Page
    {
        private hotelEntities context = new hotelEntities();
        public BookingWindow()
        {
            InitializeComponent();
            BookingView.ItemsSource = context.ViewBookingRoomDS.ToList();
            BkCbx.ItemsSource = context.ViewBookingRoomDS.ToList();
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string search = Searchtxt.Text;
            BookingView.ItemsSource = null;
            BookingView.ItemsSource = context.ViewBookingRoomDS.ToList().Where(item => item.fio.Contains(Searchtxt.Text));
            Searchtxt.Text = search;
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Searchtxt.Text = null;
            BookingView.ItemsSource = context.ViewBookingRoomDS.ToList();
        }
        private void Cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Searchtxt.Text = null;
            var selected = BkCbx.SelectedItem as ViewBookingRoom;

            if (selected != null)
            {
                BookingView.ItemsSource = context.ViewBookingRoomDS.ToList().Where(item => item.fio == selected.Фамилия);
            }

        }

    }
}
