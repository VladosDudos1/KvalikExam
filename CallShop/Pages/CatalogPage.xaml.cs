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
    public partial class CatalogPage : Page
    {
        private static List<Phone> phones = new List<Phone>();

        public CatalogPage()
        {
            InitializeComponent();
        }

        private void refreshCatalogBtn_Click(object sender, RoutedEventArgs e)
        {
            RefreshCatalog();
        }

        private void addClientBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientAddPage());
        }

        private void purchaseBtn_Click(object sender, RoutedEventArgs e)
        {
            var phone = new Phone();
            if(lvPhones.SelectedItem!= null) { 
                phone = lvPhones.SelectedItem as Phone;
                phone.DateOfBuy = DateTime.Now;
                BaseConnection.connection.Phone.FirstOrDefault();
                BaseConnection.connection.SaveChanges();

                RefreshCatalog();
            }
        }
        private void RefreshCatalog()
        {
            phones = new List<Phone>(BaseConnection.connection.Phone.ToList());
            var p = new List<Phone>();

            foreach (Phone phone in phones)
            {
                if (phone.DateOfBuy == null)
                {
                    p.Add(phone);
                }
            }
            lvPhones.ItemsSource = p;
        }

        private void backPhoneBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BackPhonePage());
        }
    }
}
