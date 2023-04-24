using ProductPRoject.Classes;
using ProductPRoject.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ProductPRoject.Pages.Views
{
    /// <summary>
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public static User user { get; set; }
        public SignUpPage(User cUser)
        {
            InitializeComponent();
            user = cUser;
            this.DataContext = this;

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            if (user.ID == 0)
            {
                user.RoleID = 1;
                AppData.db.User.Add(user);
                AppData.db.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!");
            }
            else if (user.ID != 0)
            {
                AppData.db.SaveChanges();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

      
    }
}
