using Production.Context;
using Production.Model;
using Production.Views.Pages.UserPage;
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

namespace Production.Views.Pages.AdministratorPage
{
    /// <summary>
    /// Логика взаимодействия для DataViewPageProduction.xaml
    /// </summary>
    public partial class DataViewPageProduction : Page
    {
        public DataViewPageProduction()
        {
            InitializeComponent();
            DataViewAdmin.ItemsSource = ContextConnect.db.SignIn.ToList();
        }

        private void DataAdminDeleteUsers_Click(object sender, RoutedEventArgs e)
        {
            SignIn signin = (SignIn)DataViewAdmin.SelectedItem;
            ContextConnect.db.SignIn.Remove(signin);
            ContextConnect.db.SaveChanges();
            DataViewAdmin.ItemsSource = ContextConnect.db.SignIn.ToList();
        }

        private void ExitDataViewPageAdmin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListViewProductPage());
        }
    }
}
