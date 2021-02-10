using Production.Context;
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

namespace Production.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            RoleBTN.ItemsSource = ContextConnect.db.Role.Select(itemr => itemr.TITLE).ToList();
        }

        private void RegistrationBTN_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var currentRegistration = ContextConnect.db.SignIn.FirstOrDefault(item => item.Login == RegistrationLoginBTN.Text && item.Password == RegistrationPasswordBTN.Password);
                if(currentRegistration == null)
                {
                    SignIn signin = new SignIn();
                    signin.Login = RegistrationLoginBTN.Text;
                    signin.Password = RegistrationPasswordBTN.Password;
                    var currentRole = ContextConnect.db.Role.FirstOrDefault(itemRole => itemRole.TITLE == RoleBTN.Text);
                    signin.IDrole = currentRole.roleID;
                    ContextConnect.db.SignIn.Add(signin);
                    ContextConnect.db.SaveChanges();
                    MessageBox.Show("АККАУНТ УСПЕШНО ЗАРЕГИСТРИРОВАН.", "ДОБРО ПОЖАЛОВАТЬ!", MessageBoxButton.OK, MessageBoxImage.Information);   
                }
                else
                {
 
                    MessageBox.Show("ДАННЫЕ НЕ ВВЕЛИ!..", "ОШИБКА!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void returnSignInBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignInMainPage());
        }
    }
}
