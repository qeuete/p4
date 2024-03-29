using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    public partial class AddEditPage : Page
    {
        private Clients currentClients = new Clients();
        public AddEditPage()
        {
            InitializeComponent();
            DataContext = currentClients;
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
           StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(currentClients.Surname))
                errors.AppendLine("Введите фамилию");
            if (string.IsNullOrWhiteSpace(currentClients.Firstname))
                errors.AppendLine("Введите имя");
            if (string.IsNullOrWhiteSpace(currentClients.Email))
                errors.AppendLine("Введите почту");
            if (string.IsNullOrWhiteSpace(currentClients.Number))
                errors.AppendLine("Введите номер телефона");

        }
    }
}
  