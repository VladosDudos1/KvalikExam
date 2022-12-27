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

namespace CallShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientAddPage.xaml
    /// </summary>
    public partial class ClientAddPage : Page
    {
        public ClientAddPage()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            var client = new Client();
            if (nameTb.Text.ToString().Length>0 && surnameTb.Text.ToString().Length > 0 && phoneTb.Text.ToString().Length == 11)
            {
                client.Name = nameTb.Text;
                client.Surname = surnameTb.Text;
                client.PhoneNumber = phoneTb.Text;

                BaseConnection.connection.Client.Add(client);
                BaseConnection.connection.SaveChanges();
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
