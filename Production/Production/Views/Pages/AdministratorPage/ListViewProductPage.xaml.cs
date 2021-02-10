using Production.Context;
using Production.Views.Pages.AdministratorPage;
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
using Production.Model;

namespace Production.Views.Pages.UserPage
{
    /// <summary>
    /// Логика взаимодействия для ListViewProductPage.xaml
    /// </summary>
    public partial class ListViewProductPage : Page
    {
        public ListViewProductPage()
        {
            InitializeComponent();
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListViewProduct.ItemsSource = ContextConnect.db.product.ToList();
        }

        private void NextPageAdmin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewPageProduction());
        }

        private void ExitListViewPageAdmin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DataAdminDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            product prod = (product)ListViewProduct.SelectedItem;
            if(prod != null)
            {
                ContextConnect.db.product.Remove(prod);
                ContextConnect.db.SaveChanges();
                Page_Loaded(null, null);
                MessageBox.Show("ДАННЫЕ УДАЛЕНЫ!");
            }
            else
            {
                MessageBox.Show("ВЫБЕРИТЕ ЭЛЕМЕНТ!");
            }
        }

        private void ListViewProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            product prod = (product)ListViewProduct.SelectedItem;
            NavigationService.Navigate(new EditDataPageAdmin(prod));
        }

        private void AddBTNProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProductPage());
        }

        private void SearchBTN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
