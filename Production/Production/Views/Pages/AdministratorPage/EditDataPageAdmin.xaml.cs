using Microsoft.Win32;
using Production.Context;
using Production.Model;
using Production.Views.Pages.UserPage;
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

namespace Production.Views.Pages.AdministratorPage
{
    /// <summary>
    /// Логика взаимодействия для EditDataPageAdmin.xaml
    /// </summary>
    public partial class EditDataPageAdmin : Page
    {
        private product _product;
        public EditDataPageAdmin(product _selectedItem)
        {
            InitializeComponent();
            _product = _selectedItem;
            TypicalCMBuser.ItemsSource = ContextConnect.db.Typical.Select(itemT => itemT.TITLE).ToList();
            CompanyAddCMBUser.ItemsSource = ContextConnect.db.Company.Select(itemC => itemC.NameCompany).ToList();
            MaterialCMBAddUser.ItemsSource = ContextConnect.db.Material.Select(itemM => itemM.NameMaterial).ToList();
            NameProductTextBoxUSER.Text = _selectedItem.NameProduct;
            NoteAddTBXUder.Text = _selectedItem.Note;
            if (_selectedItem.Picture != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using(MemoryStream stream = new MemoryStream(_selectedItem.Picture))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                PictureEdit.Source = bitmap;
            }
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListViewProductPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                product AddProduct = ContextConnect.db.product.FirstOrDefault(Item => Item.IDproduct == _product.IDproduct);
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
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)PictureEdit.Source));
                encoder.Save(stream);
                AddProduct.Picture = stream.ToArray();

                ContextConnect.db.SaveChanges();
                MessageBox.Show("ДАННЫЕ СОХРАНЕНЫ", "СОХРАНЕНО", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditProductBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog picture = new OpenFileDialog();
                picture.Filter = "image (*.png; *.ipeg; *jpg;) | *.png; *.ipeg; *jpg; ";
                if (picture.ShowDialog() == true)
                {
                    BitmapImage image = new BitmapImage(new Uri(picture.FileName));
                    PictureEdit.Source = image;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
