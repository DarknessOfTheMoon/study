using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using course_work_3_0.connect;
using course_work_3_0.model;

namespace course_work_3_0.views.pages
{
    /// <summary>
    /// Логика взаимодействия для viewDataPage.xaml
    /// </summary>
    public partial class viewDataPage : Page
    {
        public viewDataPage()
        {
            InitializeComponent();
        }

        private void ExitButtonChoice_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoicePage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = dbConnnect.db.students.ToList();
            dataView2.ItemsSource = dbConnnect.db.GROUP.ToList();
        }

        private void UPD_Click(object sender, RoutedEventArgs e)
        {
            dbConnnect.db.SaveChanges();
        }

        private void DEL_Click(object sender, RoutedEventArgs e)
        {
            students xx = (students)dataView.SelectedItem;
            dbConnnect.db.students.Remove(xx);
            dbConnnect.db.SaveChanges();
            dataView.ItemsSource = dbConnnect.db.students.ToList();
        }

        private void filt1_Checked(object sender, RoutedEventArgs e)
        {
            txbRezFilt.Text = dbConnnect.db.students.Where(K => K.GROUP.TITLE == "109 АП").Sum(S => S.SCHOLARSHIP).ToString();
        }

        private void filt2_Checked(object sender, RoutedEventArgs e)
        {
            txbRezFilt.Text = dbConnnect.db.students.Where(g => g.COURSE == "1").Count().ToString();
        }

        private void filt2_2_Checked(object sender, RoutedEventArgs e)
        {
            txbRezFilt.Text = dbConnnect.db.students.Where(g => g.COURSE == "2").Count().ToString();
        }

        private void filt2_3_Checked(object sender, RoutedEventArgs e)
        {
            txbRezFilt.Text = dbConnnect.db.students.Where(g => g.COURSE == "3").Count().ToString();
        }

        private void filt2_4_Checked(object sender, RoutedEventArgs e)
        {
            txbRezFilt.Text = dbConnnect.db.students.Where(g => g.COURSE == "4").Count().ToString();
        }

        private void filt2_5_Checked(object sender, RoutedEventArgs e)
        {
            txbRezFilt.Text = dbConnnect.db.students.Where(g => g.COURSE == "5").Count().ToString();
        }

        private void filt2_6_Checked(object sender, RoutedEventArgs e)
        {
            dataView2.ItemsSource = dbConnnect.db.GROUP.Where(p => p.TITLE.Contains("АП")).ToList();
        }

        private void filt2_5_Unchecked(object sender, RoutedEventArgs e)
        {
            dataView2.ItemsSource = dbConnnect.db.GROUP.ToList();
        }
    }
}
