using Microsoft.Win32;
using ProductPRoject.Classes;
using ProductPRoject.Model;
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

namespace ProductPRoject.Pages.Views.UserPages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        public OpenFileDialog file = new OpenFileDialog();
        public Product product { get; set; }
        public AddEditPage(Product cProduct)
        {
            InitializeComponent();
            product = cProduct;
            this.DataContext = this;
        }

        private void AddNewImageBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (file.ShowDialog() == true)
                {
                    ProductImage.Source = new BitmapImage(new Uri(file.FileName));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.None);
            }
        }

        private void AddEditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (product.ID == 0)
            {
                product.Image = file.FileName;
                AppData.db.Product.Add(product);
                AppData.db.SaveChanges();
                MessageBox.Show("Продукт добавлен");

            }
            else if (product.ID != 0)
            {
                product.Image = file.FileName;
                AppData.db.SaveChanges();
                MessageBox.Show("Продукт редактирован");
                
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); 
        }
    }
}
