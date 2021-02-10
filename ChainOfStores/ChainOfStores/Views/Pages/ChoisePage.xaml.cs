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
using ChainOfStores.Views.Pages.DataViews;

namespace ChainOfStores.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChoisePage.xaml
    /// </summary>
    public partial class ChoisePage : Page
    {
        public ChoisePage()
        {
            InitializeComponent();
        }

        private void addSupplyMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMainSupplyPage());
        }

        private void listNameInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewPage());
        }

        private void exitProgram_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
