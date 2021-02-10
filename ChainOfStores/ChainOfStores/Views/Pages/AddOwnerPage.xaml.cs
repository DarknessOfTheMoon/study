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
    /// Логика взаимодействия для AddOwnerPage.xaml
    /// </summary>
    public partial class AddOwnerPage : Page
    {
        public AddOwnerPage()
        {
            InitializeComponent();
        }

        private void returnAddMainSupplyPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMainSupplyPage());
        }

        private void addOwner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OWNER owner = new OWNER();
                owner.SurName = AddOwnerSurNameTXB.Text;
                owner.LastName = AddOwnerLastNameTBX.Text;
                owner.MiddleName = AddOwnerMiddleNameTBX.Text;
                owner.NumberOwner = Convert.ToInt32(AddOwnerNumberPhoneTBX.Text);
                owner.DepositAamount = Convert.ToInt32(AddOwnerDepositAamountTBX.Text);
                owner.NumberRegistration = Convert.ToInt32(AddOwnerNumberRegistrationTBX.Text);
                owner.DateRregistration = Convert.ToDateTime(AddOwnerData.DisplayDate);
                dbConnect.db.OWNER.Add(owner);
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
