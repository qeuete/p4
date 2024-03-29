using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using WpfApp1.hotelDataSetTableAdapters;

namespace WpfApp1
{
    public partial class RoomsWindow : Page
    {
        RoomsTableAdapter rooms = new RoomsTableAdapter();
        public RoomsWindow()
        {
            InitializeComponent();
            RoomsView.ItemsSource = rooms.GetData();
            AvailabilityCbx.ItemsSource = rooms.GetData();
            AvailabilityCbx.DisplayMemberPath = "AvailabilityRoom";
            RoomsCbx.ItemsSource = rooms.GetData();
        }

        private void BtnAddClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PriceTbx.Text, out int price))
            {
                if (TypeTbx.Text.Length <= 50)
                {
                    rooms.InsertQuery(TypeTbx.Text, price, AvailabilityCbx.Text);
                    RoomsView.ItemsSource = rooms.GetData();
                }
                else
                {
                    MessageBox.Show("Тип номера не должен превышать 50 символов");
                }
            }
            else
            {
                MessageBox.Show("Неверный формат цены");
            }
        }

        private void BtnEditClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PriceTbx.Text, out int price))
            {
                if (TypeTbx.Text.Length <= 50)
                {
                    object TypeRoom = (RoomsView.SelectedItem as DataRowView).Row[1];
                    rooms.UpdateQuery(TypeTbx.Text, Convert.ToInt32(price), AvailabilityCbx.Text, Convert.ToString(TypeRoom));
                    RoomsView.ItemsSource = rooms.GetData();
                }
                else
                {
                    MessageBox.Show("Тип комнаты не должен превышать 50 символов");
                }
            }
            else
            {
               MessageBox.Show("Неверный формат цены");                
            }
        }
        private void BtnDeleteClick(object sender, RoutedEventArgs e)
        {
            object TypeRoom = (RoomsView.SelectedItem as DataRowView).Row[1];
            rooms.DeleteQuery(Convert.ToString(TypeRoom));
            RoomsView.ItemsSource = rooms.GetData();
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            RoomsView.ItemsSource = rooms.SearchByType(SearchTxt.Text);   
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SearchTxt.Text = null;
            RoomsView.ItemsSource = rooms.GetData();
        }
        private void Cbx_SelectionChanged(object sender, RoutedEventArgs e)
        {
            SearchTxt.Text = null;
            string TypeRoom = (RoomsCbx.SelectedItem as DataRowView)["TypeRoom"].ToString();
            RoomsView.ItemsSource = rooms.FilterByType(TypeRoom);   
        }
    }
}
