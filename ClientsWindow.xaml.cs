using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class ClientsWindow : Page
    {
        private hotelEntities context = new hotelEntities();
        public ClientsWindow()
        {
            InitializeComponent();
            ClientsDgr.ItemsSource = context.Clients.ToList();
            ClientsCbx.ItemsSource = context.Clients.ToList();      
        }
        private void BtnEditClick(object sender, RoutedEventArgs e)
        {
            if (ClientsDgr.SelectedItem != null)
            {
                var selected = ClientsDgr.SelectedItem as Clients;
                string surname = SurnameTbx.Text;
                string firstname = FirstnameTbx.Text;
                string middlename = MiddlenameTbx.Text;
                string email = EmailTbx.Text;
                string number = NumberTbx.Text;
                string dateOfBirthText = DateOfBirthTbx.Text;

                if (string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(number) || string.IsNullOrEmpty(dateOfBirthText))
                {
                    MessageBox.Show("Не все поля заполнены.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (surname.Length > 100 || firstname.Length > 100 || middlename.Length > 100)
                {
                    MessageBox.Show("Длина одного из полей Surname, Firstname или Middlename превышает 100 символов.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!email.Contains("@") || email.Length > 50)
                {
                    MessageBox.Show("Email должен содержать символ @ и не превышать 50 символов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (number.Length > 11)
                {
                    MessageBox.Show("Номер должен быть не более 11 цифр.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                try
                {
                    selected.Surname = SurnameTbx.Text;
                    selected.Firstname = FirstnameTbx.Text;
                    selected.Middlename = MiddlenameTbx.Text;
                    selected.Email = EmailTbx.Text;
                    selected.Number = NumberTbx.Text;

                    selected.DateofBirth = DateTime.ParseExact(DateOfBirthTbx.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при редактировании: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                context.SaveChanges();
                ClientsDgr.ItemsSource = context.Clients.ToList();
            }
        }
        private void BtnAddClick(object sender, RoutedEventArgs e)
        {
            Clients client = new Clients();

            string surname = SurnameTbx.Text;
            string firstname = FirstnameTbx.Text;
            string middlename = MiddlenameTbx.Text;
            string email = EmailTbx.Text;
            string number = NumberTbx.Text;
            string dateOfBirthText = DateOfBirthTbx.Text;

            if (string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(number) || string.IsNullOrEmpty(dateOfBirthText))
            {
                MessageBox.Show("Не все поля заполнены.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (surname.Length > 100 || firstname.Length > 100 || middlename.Length > 100)
            {
                MessageBox.Show("Длина одного из полей Surname, Firstname или Middlename превышает 100 символов.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!email.Contains("@") || email.Length > 50)
            {
                MessageBox.Show("Email должен содержать символ @ и не превышать 50 символов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (number.Length > 11)
            {
                MessageBox.Show("Номер телефона должен быть не более 11 цифр.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                client.DateofBirth = DateTime.ParseExact(dateOfBirthText, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Ошибка преобразования даты: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            client.Surname = surname;
            client.Firstname = firstname;
            client.Middlename = middlename;
            client.Email = email;
            client.Number = number;

            context.Clients.Add(client);
            context.SaveChanges();
            ClientsDgr.ItemsSource = context.Clients.ToList();
        }

        private void BtnDeleteClick(object sender, RoutedEventArgs e)
        {
            Clients selectClients = (Clients)ClientsDgr.SelectedItem;

            if (selectClients != null)
    {
                RemoveClients(selectClients.ID_Client);

                context.Clients.Remove(selectClients);
                context.SaveChanges();

                ClientsDgr.ItemsSource = context.Clients.ToList();
            }
        }

        private void RemoveClients(int clientID)
        {
            var selectClients = context.BookingRoom.Where(x => x.Client_ID == clientID).ToList();
            context.BookingRoom.RemoveRange(selectClients);
            context.SaveChanges();
        }
        private void UpdateStudentsCourses()
        {
            foreach (var selectClients in context.BookingRoom.ToList())
            {
                if (!context.Clients.Any(x => x.ID_Client == selectClients.Client_ID) ||
                    !context.Rooms.Any(z => z.ID_Room == selectClients.Room_ID))
                {
                    context.BookingRoom.Remove(selectClients);
                }
            }

            foreach (var clients in context.Clients)
            {
                var Booktb = context.BookingRoom
                    .Where(x => x.Client_ID == clients.ID_Client)
                    .Select(z => z.Room_ID)
                    .ToList();

                foreach (var roomId in Booktb)
                {
                    if (!context.BookingRoom.Any(x => x.Client_ID == clients.ID_Client && x.Room_ID == roomId))
                    {
                        context.BookingRoom.Add(new BookingRoom()
                        {
                            Client_ID = clients.ID_Client,
                            Room_ID = roomId
                        });
                    }
                }
            }
            context.SaveChanges();  
        }
                private void BtnAddExit(object sender, RoutedEventArgs e)
                {
                    MainWindow win = new MainWindow();
                    win.Show();
                }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchTxt.Text;
            ClientsDgr.ItemsSource = null;
            ClientsDgr.ItemsSource = context.Clients.ToList().Where(item => item.Surname.Contains(SearchTxt.Text));
            SearchTxt.Text = search;
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SearchTxt.Text = null;
            ClientsDgr.ItemsSource = context.Clients.ToList(); 
        }
        private void Cbx_SelectionChanged(object sender, RoutedEventArgs e)
        {
            SearchTxt.Text = null;
            var selected = ClientsCbx.SelectedItem as Clients;

            if (selected != null)
            {
                ClientsDgr.ItemsSource = context.Clients.ToList().Where(item => item.Firstname == selected.Firstname);
            }

        }
    }
   
}