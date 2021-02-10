using Production.Model;
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
using Production.Context;
using Production.Views.Pages.AdministratorPage;
using Production.Views.Pages.UserPage;

namespace Production.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignInMainPage.xaml
    /// </summary>
    public partial class SignInMainPage : Page
    {
        public SignInMainPage()
        {
            InitializeComponent();
        }

        private void SignInUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var current = ContextConnect.db.SignIn.FirstOrDefault(item => item.Login == SignInLoginMainPageBTN.Text && item.Password == SignInPasswordMainPageBTN.Password);
                if (current != null)
                {
                    switch (current.IDrole){
                        case "A":
                            MessageBox.Show("Добро пожаловать ADMIN, " + current.Login);
                            NavigationService.Navigate(new DataViewPageProduction());
                            break;
                        case "U":
                            MessageBox.Show("Добро пожаловать USER, " + current.Login);
                            NavigationService.Navigate(new AddProductPage());
                            break;
                    }   
                }
                else
                {
    
                    MessageBox.Show("ВЫ НЕ ВВЕЛИ ДАННЫЕ, ПОВТОРИТЕ ПОПЫТКУ!", "НЕ ВЕРНО!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ExitProgramBTN_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegistrationUserBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
