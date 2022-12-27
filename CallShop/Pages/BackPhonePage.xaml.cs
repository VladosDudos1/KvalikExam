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
    /// Логика взаимодействия для BackPhonePage.xaml
    /// </summary>
    public partial class BackPhonePage : Page
    {
        private static List<Phone> phones = new List<Phone>();
        public BackPhonePage()
        {
            InitializeComponent();
            phones = new List<Phone>(BaseConnection.connection.Phone.ToList());
            var p = new List<Phone>();

            foreach (Phone phone in phones)
            {
                if (phone.DateOfBuy != null)
                {
                    p.Add(phone);
                }
            }
            lvPhones.ItemsSource = p;
        }

        private void purchaseBtn_Click(object sender, RoutedEventArgs e)
        {
            var phone = new Phone();
            if (lvPhones.SelectedItem != null)
            {
                phone = lvPhones.SelectedItem as Phone;
                phone.DateOfBuy = null;
                BaseConnection.connection.Phone.FirstOrDefault();
                BaseConnection.connection.SaveChanges();

                NavigationService.Navigate(new BackPhonePage());
            }
        }
    }


}
