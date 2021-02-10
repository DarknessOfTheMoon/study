using ChainOfStores.Connect;
using ChainOfStores.Model;
using ChainOfStores.Views.Pages.DataViews;
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
    /// Логика взаимодействия для DataViewPage.xaml
    /// </summary>
    public partial class DataViewPage : Page
    {
        public DataViewPage()
        {
            InitializeComponent();
            DataViewProvid.ItemsSource = dbConnect.db.SUPPLY.ToList();
        }

        private void returnDataViewPageinChoicePage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoisePage());
        }

        private void NextPageOne_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewProvider());
        }

        private void EditBTN_Click(object sender, RoutedEventArgs e)
        {
            dbConnect.db.SaveChanges();
        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            SUPPLY supplDel = (SUPPLY)DataViewProvid.SelectedItem;
            dbConnect.db.SUPPLY.Remove(supplDel);
            dbConnect.db.SaveChanges();
            DataViewProvid.ItemsSource = dbConnect.db.SUPPLY.ToList();
        }
    }
}
