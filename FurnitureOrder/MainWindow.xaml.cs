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
using FurnitureOrder.dataBase;


namespace FurnitureOrder
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool hasEntered = false;
        public Context bd;
        public User user;

        public MainWindow()
        {
            InitializeComponent();
            bd = new Context();

            MainFrame.Navigate(new Pages.Authorization(this));
            logOut.Visibility = Visibility.Hidden;
        }


        private void AuthorizationPageClick(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Visibility = Visibility.Hidden;
            Title = "Аутентификация";
            MainFrame.Navigate(new Pages.Authorization(this));
        }

        public void FurnituraClick(object sender, RoutedEventArgs e)
        {

        }

        public void MaterialsClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
