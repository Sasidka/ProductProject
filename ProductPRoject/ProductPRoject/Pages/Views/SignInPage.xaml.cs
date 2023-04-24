using ProductPRoject.Classes;
using ProductPRoject.Model;
using ProductPRoject.Pages.Views.StorekeeperPages;
using ProductPRoject.Pages.Views.UserPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace ProductPRoject.Pages.Views
{
    /// <summary>
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public static CustomItems customItems { get; set; }
        public static Fittings fittings { get; set; }
        public SignInPage()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.User.FirstOrDefault(x => x.Password == PasswordTb.Password && x.Login == LoginTb.Text);


            if (CurrentUser != null )
            {
                switch (CurrentUser.RoleID)
                {
                    case 1:
                        NavigationService.Navigate(new MainPage(CurrentUser, customItems));
                        break;
                    case 2:
                        NavigationService.Navigate(new AccessoriesPage(CurrentUser, fittings));
                        break;
                    case 3:                 
                        break;
                    default:
                        break;
                }
            }
            else if (true)
            {

            }
            else 
            {
                MessageBox.Show("Вы ввели неверный пароль или логин, повторите попытку", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUpPage(new User()));
        }

     
    }
}
