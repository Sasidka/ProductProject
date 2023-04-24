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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static User user { get; set; }
        public static CustomItems customItems { get; set; }
        public MainPage(User cUser, CustomItems cCustomItems)
        {
            InitializeComponent();
            user = cUser;
            customItems = cCustomItems;
            this.DataContext = this;
        }

        private void SearchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
             ProductLV.ItemsSource = AppData.db.Product.Where(item => item.Name.Contains(SearchTxb.Text)).ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                NavigationService.GoBack();
            }
        }

        private void FiltrCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentFiltr = FiltrCmb.SelectedItem as Product;

            if (currentFiltr != null)
            {
                ProductLV.ItemsSource = AppData.db.Product.Where(item => item.Name == currentFiltr.Name).ToList();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               Product DeleteProduct = (Product)ProductLV.SelectedItem;
                if (DeleteProduct == null)
                {
                    MessageBox.Show("Вы не выбрали товар", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (DeleteProduct != null)
                {
                    AppData.db.Product.Remove(DeleteProduct);
                    AppData.db.SaveChanges();
                    Page_Loaded(null, null);
                    MessageBox.Show("Продукт был успешно удален!","Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPage(new Product()));
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentProduct = ProductLV.SelectedItem as Product;

            NavigationService.Navigate(new AddEditPage(currentProduct));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ProductLV.ItemsSource = AppData.db.Product.ToList();
            FiltrCmb.ItemsSource = AppData.db.Product.ToList();
        }
    }
}
