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
    /// Логика взаимодействия для fillInPagesxaml.xaml
    /// </summary>
    public partial class fillInPagesxaml : Page
    {
        public fillInPagesxaml()
        {
            InitializeComponent();
            Add_cmbGender.ItemsSource = dbConnect.db.Gender.Select(itemG => itemG.name).ToList();
            Add_citizenship.ItemsSource = dbConnect.db.citizenship.Select(itemC => itemC.title).ToList();
            Add_flight.ItemsSource = dbConnect.db.flight.Select(itemF => itemF.FlifhtId).ToList();
        }

        private void return_btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new mainPages());
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                passengers passenger = new passengers();
                passenger.surName = Add_name.Text;
                passenger.lastName = Add_lastname.Text;
                passenger.MaddleName = Add_middlename.Text;
                var currentGender = dbConnect.db.Gender.FirstOrDefault(itemG => itemG.name == Add_cmbGender.Text);
                passenger.genderID = currentGender.IDgender;
                passenger.passportID = Convert.ToInt32(Add_passport.Text);
                var currentCitizenship = dbConnect.db.citizenship.FirstOrDefault(itemC => itemC.title == Add_citizenship.Text);
                passenger.citizenshipID = currentCitizenship.IDcitizenship;
                var currentFlight = dbConnect.db.flight.FirstOrDefault(itemF => itemF.FlifhtId == Add_flight.Text);
                passenger.idFlight = currentFlight.FlifhtId;
                dbConnect.db.passengers.Add(passenger);
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
