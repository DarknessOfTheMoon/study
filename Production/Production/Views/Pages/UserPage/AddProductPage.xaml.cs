using Microsoft.Win32;
using Production.Context;
using Production.Model;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Production.Views.Pages.UserPage
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();
            TypicalCMBuser.ItemsSource = ContextConnect.db.Typical.Select(itemT => itemT.TITLE).ToList();
            CompanyAddCMBUser.ItemsSource = ContextConnect.db.Company.Select(itemC => itemC.NameCompany).ToList();
            MaterialCMBAddUser.ItemsSource = ContextConnect.db.Material.Select(itemM => itemM.NameMaterial).ToList();

        }

        private void AddProductUserPage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                product AddProduct = new product();
                AddProduct.NameProduct = NameProductTextBoxUSER.Text;

                var currentTypical = ContextConnect.db.Typical.FirstOrDefault(itemTypical => itemTypical.TITLE == TypicalCMBuser.Text);
                AddProduct.IsTypicalID = currentTypical.IDtypical;

                AddProduct.Note = NoteAddTBXUder.Text;

                var currentCompany = ContextConnect.db.Company.FirstOrDefault(itemCompany => itemCompany.NameCompany == CompanyAddCMBUser.Text);
                AddProduct.ManufacturingСompany = currentCompany.IDcompany;

                var currentMaterial = ContextConnect.db.Material.FirstOrDefault(itemMaterial => itemMaterial.NameMaterial == MaterialCMBAddUser.Text);
                AddProduct.MaterialID = currentMaterial.IDMaterial;

                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)AddPicture.Source));
                encoder.Save(stream);
                AddProduct.Picture = stream.ToArray();

                ContextConnect.db.product.Add(AddProduct);
                ContextConnect.db.SaveChanges();
                MessageBox.Show("ДАННЫЕ СОХРАНЕНЫ", "СОХРАНЕНО", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void AddPictureProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog picture = new OpenFileDialog();
                picture.Filter = "image (*.png; *.ipeg; *jpg;) | *.png; *.ipeg; *jpg; ";
                    if(picture.ShowDialog() == true)
                        {
                            BitmapImage image = new BitmapImage(new Uri(picture.FileName));
                            AddPicture.Source = image;
                        }

             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExitBTNUserPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignInMainPage());
        }
    }
}
