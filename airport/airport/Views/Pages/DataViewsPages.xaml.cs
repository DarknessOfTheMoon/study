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
using airport.Model;
using airport.Connect;

namespace airport.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataViewsPages.xaml
    /// </summary>
    public partial class DataViewsPages : Page
    {
        public DataViewsPages()
        {
            InitializeComponent();
        }

        private void returnDataView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new mainPages());
        }

        private void flightDataView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataGridflight());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListDataView.ItemsSource = dbConnect.db.passengers.ToList();
        }

        private void editingDataViewBTN_Click(object sender, RoutedEventArgs e)
        {
            dbConnect.db.SaveChanges();
        }

        private void deleteDataViewBTN_Click(object sender, RoutedEventArgs e)
        {
            passengers del = (passengers)ListDataView.SelectedItem;
            dbConnect.db.passengers.Remove(del);
            dbConnect.db.SaveChanges();
            ListDataView.ItemsSource = dbConnect.db.passengers.ToList();
        }

        private void searchTBX_TextChanged(object sender, TextChangedEventArgs e)
        {
            //ListDataView.ItemsSource = dbConnect.db.passengers.Where(itemData => itemData.lastName.Contains(searchTBX.Text));
        }
    }
}
