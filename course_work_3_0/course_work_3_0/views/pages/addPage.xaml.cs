using course_work_3_0.connect;
using course_work_3_0.model;
using course_work_3_0.classes;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Linq;
using course_work_3_0.views.pages;

namespace course_work_3_0.views.pages
{
    /// <summary>
    /// Логика взаимодействия для addPages.xaml
    /// </summary>
    public partial class addPages : Page
    {
        public addPages()
        {
            InitializeComponent();
            INSERT_GROUP.ItemsSource = dbConnnect.db.GROUP.Select(itemGroup => itemGroup.TITLE).ToList();
        }

        private void ReturnMainPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoicePage());
        }

        private void AddingButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ADDButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                students stud = new students();
                stud.NAME = INSERT_NAME.Text;
                stud.DATEOFBIRTH = Convert.ToDateTime(INSERT_DATE_BORN.SelectedDate);
                stud.MARITALSTATUS = INSERT_MARITALSTATUS.Text;
                var currentGroup = dbConnnect.db.GROUP.FirstOrDefault(itemG => itemG.TITLE == INSERT_GROUP.Text);
                stud.IDGROUP = currentGroup.GROUPID;
                stud.COURSE = INSERT_COURSE.Text;
                stud.YEAROFENROLLMENT = Convert.ToDateTime(INSERT_YEAR_ROLLMENT.Text);
                stud.SCHOLARSHIP = Convert.ToInt32(INSERT_SCHOLARSHIP.Text);
                dbConnnect.db.students.Add(stud);
                dbConnnect.db.SaveChanges();
                MessageBox.Show("ДАННЫЕ СОХРАНЕНЫ!", "СОХРАНЕНО", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        
    }
}
