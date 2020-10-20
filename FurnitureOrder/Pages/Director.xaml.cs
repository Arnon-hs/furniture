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
    /// Логика взаимодействия для Director.xaml
    /// </summary>
    public partial class Director : Page
    {
        MainWindow main;
        Equipment record;
        Button button;
        public Director(MainWindow main)
        {
            this.main = main;
            InitializeComponent();

            foreach (Equipment equipment in main.bd.Equipment)
            {
                Button button = new Button();
                button.Content = equipment.marking + " " + equipment.name + " " + equipment.TypeOfEquipment.name;
                button.FontSize = 15;
                button.Click += recordClick;
                button.DataContext = equipment;
                cinemas.Children.Add(button);
            }

            foreach(TypeOfEquipment type in main.bd.TypeOfEquipment)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.DataContext = type;
                item.Content = type.name;
                types.Items.Add(item);
            }
        }

        public void FurnituraClick(object sender, RoutedEventArgs e)
        {
            main.MainFrame.Navigate(new ReferenceBookAdmin(main, true));
        }

        public void MaterialsClick(object sender, RoutedEventArgs e)
        {
            main.MainFrame.Navigate(new ReferenceBookAdmin(main, false));
        }

        private void recordClick(object sender, RoutedEventArgs e)
        {
            Equipment cinema = (Equipment)((Button)sender).DataContext;
            deleteCinemaButton.Visibility = Visibility.Visible;
            changeCinemaButton.Visibility = Visibility.Visible;
            marking.Text = cinema.marking;
            foreach (ComboBoxItem item in types.Items) {
                if (item.Content.ToString() == cinema.TypeOfEquipment.name)
                    types.SelectedItem = item;
            }
            characteristics.Text = cinema.characteristics;
            date.DisplayDate = cinema.data ?? new DateTime();
            name.Text = cinema.name;
            
            this.record = cinema;

            this.button = (Button)sender;
        }

        private void CreateCinemaClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Equipment item = new Equipment();
                item.marking = marking.Text;

                item.type = ((TypeOfEquipment)((ComboBoxItem)types.SelectedItem).DataContext).name;
                item.characteristics = characteristics.Text;
                item.name = name.Text;
                item.data = date.DisplayDate;
                main.bd.Equipment.Add(item);
                main.bd.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void DeleteCinemaClick(object sender, RoutedEventArgs e)
        {
            main.bd.Equipment.Remove(record);
            main.bd.SaveChanges();
            cinemas.Children.Remove(button);
            changeCinemaButton.Visibility = Visibility.Hidden;
            deleteCinemaButton.Visibility = Visibility.Hidden;
        }


        private void ChangeCinemaClick(object sender, RoutedEventArgs e)
        {
            try
            {
                record.marking = marking.Text;

                record.marking = marking.Text;

                record.type = ((TypeOfEquipment)((ComboBox)types.SelectedItem).DataContext).name;
                record.characteristics = characteristics.Text;
                record.name = name.Text;
                record.data = date.DisplayDate;
                main.bd.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }
    }
}
