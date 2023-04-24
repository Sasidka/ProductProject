using ProductPRoject.Classes;
using ProductPRoject.Model;
using ProductPRoject.Pages.Views.UserPages;
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

namespace ProductPRoject.Pages.Views.StorekeeperPages
{
    /// <summary>
    /// Логика взаимодействия для AccessoriesPage.xaml
    /// </summary>
    public partial class AccessoriesPage : Page
    {
        public Fittings fittings { get; set; }
        public AccessoriesPage(User user, Fittings cFittings)
        {
            InitializeComponent();
            fittings = cFittings;
            this.DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AccomodationLV.ItemsSource = AppData.db.Accommodation.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                NavigationService.GoBack();
            }
        }

        private void SearchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            AccomodationLV.ItemsSource = AppData.db.Accommodation.Where(item => item.Name.Contains(SearchTxb.Text) 
            || item.Type.Contains(SearchTxb.Text));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var deleteCheck = (Accommodation)AccomodationLV.SelectedItem;

                if (deleteCheck != null)
                {
                    AppData.db.Accommodation.Remove(deleteCheck);
                    AppData.db.SaveChanges();
                    Page_Loaded(null, null);
                }
                else
                {
                    throw new Exception("Для удаления выберите элемент из списка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.None);
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditAccommodationPage(new Accommodation()));
        }
        
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentAccommodation = AccomodationLV.SelectedItem as Accommodation;

            NavigationService.Navigate(new AddEditAccommodationPage(currentAccommodation));
        }


        private void FiltrCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentFiltr = FiltrCmb.SelectedItem as Accommodation;

            if (currentFiltr != null)
            {
                AccomodationLV.ItemsSource = AppData.db.Accommodation.Where(item => item.Type == currentFiltr.Type).ToList();
            }
        }
    }
}
