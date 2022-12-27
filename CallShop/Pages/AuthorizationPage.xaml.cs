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
    public partial class AuthorizationPage : Page
    {
        private static List<User> users = new List<User>();
        public AuthorizationPage()
        {
            InitializeComponent();

            DataContext = this;
        }
        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            users = new List<User>(BaseConnection.connection.User.ToList());
            var k = users.Where(a => a.Login == LoginTB.Text && a.Password == PasswordTB.Password).FirstOrDefault();
            if (k != null)
            {
                DataManager.roleId = Convert.ToInt32(k.IdRole);
                if (DataManager.roleId != 1)
                {
                    NavigationService.Navigate(new NotAdminPage());
                }
                else
                    NavigationService.Navigate(new CatalogPage());

            }
            else
            {
                MessageBox.Show("Юзер не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
