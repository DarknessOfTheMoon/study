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
    /// Логика взаимодействия для AddSupplyPage.xaml
    /// </summary>
    public partial class AddSupplyPage : Page
    {
        public AddSupplyPage()
        {
            InitializeComponent();
            AddShopSupply.ItemsSource = dbConnect.db.STORE.Select(itemShop => itemShop.NameStore).ToList();
            AddShopProvide.ItemsSource = dbConnect.db.PROVIDER.Select(itemP => itemP.SurName).ToList();
        }

        private void returnAddMainSupplyPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMainSupplyPage());
        }

        private void addSupply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SUPPLY supply = new SUPPLY();

                var currentShopIDShop = dbConnect.db.STORE.FirstOrDefault(ItemsS => ItemsS.NameStore == AddShopSupply.Text);
                supply.storeID = currentShopIDShop.IDstore;

                var currentShopIdProvide = dbConnect.db.PROVIDER.FirstOrDefault(ItemP => ItemP.SurName == AddShopProvide.Text);
                supply.providerID = currentShopIdProvide.IDprovide;

                dbConnect.db.SUPPLY.Add(supply);
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
