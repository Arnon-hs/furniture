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

namespace FurnitureOrder.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        MainWindow main;
        public Authorization(MainWindow main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void LoginPageClick(object sender, RoutedEventArgs e)
        {
            AuthotizationFrame.Navigate(new Login(main));
        }

        private void RegistrationPageClick(object sender, RoutedEventArgs e)
        {
            AuthotizationFrame.Navigate(new Registration(main));
        }
    }
}
