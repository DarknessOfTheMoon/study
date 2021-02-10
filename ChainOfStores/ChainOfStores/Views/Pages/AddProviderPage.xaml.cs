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
    /// Логика взаимодействия для AddProviderPage.xaml
    /// </summary>
    public partial class AddProviderPage : Page
    {
        public AddProviderPage()
        {
            InitializeComponent();
        }

        private void returnAddProviderPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMainSupplyPage());
        }

        private void AddProvider_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PROVIDER prov = new PROVIDER();
                prov.LastName = AddNameProvider.Text;
                prov.SurName = AddSurNameProvider.Text;
                prov.MiddleName = AddMiddleNameProvider.Text;
                prov.NumberProvider = Convert.ToInt32(AddNumberProvider.Text);
                prov.DeliveryCost = Convert.ToInt32(AddDeliveryCostProvider.Text);
                dbConnect.db.PROVIDER.Add(prov);
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
