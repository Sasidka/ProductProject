using Microsoft.Win32;
using ProductPRoject.Classes;
using ProductPRoject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    /// Логика взаимодействия для AddEditAccommodationPage.xaml
    /// </summary>
    public partial class AddEditAccommodationPage : Page
    {
        public Accommodation accommodation { get; set; }
        
        public OpenFileDialog file = new OpenFileDialog();
        public AddEditAccommodationPage(Accommodation cAccommodation)
        {
            InitializeComponent();
            accommodation = cAccommodation;
            this.DataContext = this;
        }

        private void AddEditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (accommodation.ID == 0)
            {
                accommodation.Image = file.FileName;
                AppData.db.Accommodation.Add(accommodation);
                AppData.db.SaveChanges();
                NavigationService.GoBack();
            }
            else if (accommodation.ID != 0)
            {
                accommodation.Image = file.FileName;
                AppData.db.SaveChanges();
                NavigationService.GoBack();
            }
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

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
