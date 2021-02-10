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

namespace course_work_3_0.views.pages
{
    /// <summary>
    /// Логика взаимодействия для ChoicePage.xaml
    /// </summary>
    public partial class ChoicePage : Page
    {
        public ChoicePage()
        {
            InitializeComponent();
        }

        private void ButtonAddTo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addPages());
        }

        private void listButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new viewDataPage());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
