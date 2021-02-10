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
    /// Логика взаимодействия для DataGridflight.xaml
    /// </summary>
    public partial class DataGridflight : Page
    {
        public DataGridflight()
        {
            InitializeComponent();
        }

        private void returnDataFlight_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewsPages());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListDataFlight.ItemsSource = dbConnect.db.flight.ToList();
        }

        private void dataView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
