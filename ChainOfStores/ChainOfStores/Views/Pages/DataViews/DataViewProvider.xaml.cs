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
    /// Логика взаимодействия для DataViewProvider.xaml
    /// </summary>
    public partial class DataViewProvider : Page
    {
        public DataViewProvider()
        {
            InitializeComponent();
        }

        private void NextPageTwo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewOwner());
        }

        private void returnDataViewProviderInDataViewPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoisePage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataViewProviderList.ItemsSource = dbConnect.db.PROVIDER.ToList();
        }

        private void DataViewProviderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditBTN_Click(object sender, RoutedEventArgs e)
        {
            dbConnect.db.SaveChanges();
        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            PROVIDER ProviderDel = (PROVIDER)DataViewProviderList.SelectedItem;
            dbConnect.db.PROVIDER.Remove(ProviderDel);
            dbConnect.db.SaveChanges();
            DataViewProviderList.ItemsSource = dbConnect.db.PROVIDER.ToList();
        }
    }
}
