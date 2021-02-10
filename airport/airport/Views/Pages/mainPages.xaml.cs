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
using airport.Views.Pages;

namespace airport.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для mainPages.xaml
    /// </summary>
    public partial class mainPages : Page
    {
        public mainPages()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void flightBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataViewsPages());
        }

        private void fillInBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new fillInPagesxaml());
        }
    }
}
