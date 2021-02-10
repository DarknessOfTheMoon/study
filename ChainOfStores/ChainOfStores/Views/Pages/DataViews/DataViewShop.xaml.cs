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

namespace ChainOfStores.Views.Pages.DataViews
{
    /// <summary>
    /// Логика взаимодействия для DataViewShop.xaml
    /// </summary>
    public partial class DataViewShop : Page
    {
        public DataViewShop()
        {
            InitializeComponent();
            DataViewAddShop.ItemsSource = dbConnect.db.STORE.ToList(); 
        }

        private void NextPageFour_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewPage());
        }

        private void returnDataViewPageinChoicePage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoisePage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditBTN_Click(object sender, RoutedEventArgs e)
        {
            dbConnect.db.SaveChanges();
        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            STORE shopDel = (STORE)DataViewAddShop.SelectedItem;
            dbConnect.db.STORE.Remove(shopDel);
            dbConnect.db.SaveChanges();
            DataViewAddShop.ItemsSource = dbConnect.db.STORE.ToList();
        }
    }
}
