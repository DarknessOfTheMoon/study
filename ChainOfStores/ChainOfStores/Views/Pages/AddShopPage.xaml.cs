using ChainOfStores.Connect;
using ChainOfStores.Model;
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

namespace ChainOfStores.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddShopPage.xaml
    /// </summary>
    public partial class AddShopPage : Page
    {
        public AddShopPage()
        {
            InitializeComponent();
            AddShopOwner.ItemsSource = dbConnect.db.OWNER.Select(itemOwner => itemOwner.SurName).ToList();
            AddShopPprofile.ItemsSource = dbConnect.db.PROFILE.Select(itemProfile => itemProfile.TITLE).ToList();
        }

        private void returnAddShopPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMainSupplyPage());
        }

        private void addOwner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                STORE shop = new STORE();
                shop.NameStore = AddShopNameTBX.Text;
                shop.Address = AddShopAddressTBX.Text;
                shop.NumberStore = Convert.ToInt32(AddShopNumberShopTBX.Text);
                shop.AuthorizedCapital = AddAuthorizedCapitalShopTXB.Text;

                var currentAddOwnerShop = dbConnect.db.OWNER.FirstOrDefault(itemO => itemO.SurName == AddShopOwner.Text);
                shop.ownerID = currentAddOwnerShop.IDowner;

                var currentAddProfileShop = dbConnect.db.PROFILE.FirstOrDefault(itemP => itemP.TITLE == AddShopPprofile.Text);
                shop.IDprofile = currentAddProfileShop.profileID;

                dbConnect.db.STORE.Add(shop);
                dbConnect.db.SaveChanges();
                MessageBox.Show("ДАННЫЕ СОХРАНЕНЫ", "СОХРАНЕНО", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }



            
        }
    }
}
