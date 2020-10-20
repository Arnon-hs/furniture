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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        MainWindow main;
        public Login(MainWindow main)
        {
            this.main = main;
            InitializeComponent();
            generate();

        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            if (capchaText.Text == capcha.Text)
            {
                foreach (User user in main.bd.User)
                {
                    if (user.login == login.Text && user.password == password.Password)
                    {
                        try
                        {
                            main.hasEntered = true;
                            main.user = user;
                            if (user.role.ToLower() == "Заместитель директора".ToLower()) {
                                main.Title = "Заместитель директора";
                                main.MainFrame.Navigate(new DeputyDirector(main));
                            }
                            else if (user.role.ToLower() == "директор".ToLower())
                            {
                                main.Title = "Директор";
                                main.MainFrame.Navigate(new Director(main));
                            }
                                
                            else if (user.role.ToLower() == "менеджер".ToLower())
                            {
                                main.Title = "Менеджер";
                                main.MainFrame.Navigate(new Meneger(main));
                            }
                                
                            else if (user.role.ToLower() == "мастер".ToLower())
                            {
                                main.Title = "Мастер";
                                main.MainFrame.Navigate(new Master(main));
                            }
                                
                            else if (user.role.ToLower() == "заказчик".ToLower())
                            {
                                main.Title = "Заказчик";
                                main.MainFrame.Navigate(new Customer(main));
                            }
                                
                            main.logOut.Visibility = Visibility.Visible;
                        }
                        catch
                        {

                        }


                    }
                }
                if (!main.hasEntered)
                {
                    MessageBox.Show("Введены неверные данные. Попробуйте снова");
                }
            }
            else
            {
                generate();
                MessageBox.Show("Неправильная капча");
            }

        }

        private void generate()
        {
            capcha.Text = "";
            string simbols = "qwertyuiopasdfghjklzxcvbnm1234567890";
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                capcha.Text += simbols[random.Next(0, simbols.Length - 1)];
            }
        }
    }
}
