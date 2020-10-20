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
    /// Логика взаимодействия для DeputyDirector.xaml
    /// </summary>
    public partial class DeputyDirector : Page
    {
        MainWindow main;
        public DeputyDirector(MainWindow main)
        {
            this.main = main;
            InitializeComponent();
        }

        public void FurnituraClick(object sender, RoutedEventArgs e)
        {
            main.MainFrame.Navigate(new ReferenceBookAdmin(main, true));
        }

        public void MaterialsClick(object sender, RoutedEventArgs e)
        {
            main.MainFrame.Navigate(new ReferenceBookAdmin(main, false));
        }
    }
}
