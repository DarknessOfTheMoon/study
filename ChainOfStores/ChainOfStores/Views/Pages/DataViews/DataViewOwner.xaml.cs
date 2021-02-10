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
    /// Логика взаимодействия для DataViewOwner.xaml
    /// </summary>
    public partial class DataViewOwner : Page
    {
        public DataViewOwner()
        {
            InitializeComponent();
        }

        private void NextPageFhree_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewShop());
        }

        private void returnDataViewPageinChoicePage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoisePage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataViewAddOwner.ItemsSource = dbConnect.db.OWNER.ToList();
        }

        private void EditBTN_Click(object sender, RoutedEventArgs e)
        {
            dbConnect.db.SaveChanges();
        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            OWNER ownerDel = (OWNER)DataViewAddOwner.SelectedItem;
            dbConnect.db.OWNER.Remove(ownerDel);
            dbConnect.db.SaveChanges();
            DataViewAddOwner.ItemsSource = dbConnect.db.OWNER.ToList();
        }

    }
}
