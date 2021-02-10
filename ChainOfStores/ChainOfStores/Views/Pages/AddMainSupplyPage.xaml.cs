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
    /// Логика взаимодействия для AddMainSupplyPage.xaml
    /// </summary>
    public partial class AddMainSupplyPage : Page
    {
        public AddMainSupplyPage()
        {
            InitializeComponent();
        }

        private void addMainSupplyBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddSupplyPage());
        }

        private void returnInChoisePage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoisePage());
        }

        private void AddInProviderBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProviderPage());
        }

        private void AddInOwnerBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOwnerPage());
        }

        private void AddShopBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddShopPage());
        }
    }
}
