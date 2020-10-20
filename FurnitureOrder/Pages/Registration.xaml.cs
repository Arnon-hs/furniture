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
using System.Text.RegularExpressions;

namespace FurnitureOrder.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        MainWindow main;
        int code;
        public Registration(MainWindow main)
        {
            this.main = main;
            InitializeComponent();
        }
        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if (password.Password.Length > 5 && password.Password.Length < 19)
            {
                var pattern = @"(.)\1{2}";
                var pattern2 = @"[1-9]{1}";
                var pattern3 = @"[*&{}|+.]{1}";
                if (!Regex.IsMatch(password.Password, pattern))
                {
                    if (Regex.IsMatch(password.Password, pattern2))
                    {
                        if (Regex.IsMatch(password.Password, pattern3))
                        {
                            User user = new User();
                            user.Имя = name.Text;
                            user.Фамилия = surname.Text;
                            user.Отчество = patronymic.Text;
                            user.login = login.Text;
                            user.password = password.Password;
                            user.role = "заказчик";
                            try
                            {
                                main.bd.User.Add(user);
                            
                                main.bd.SaveChanges();
                                MessageBox.Show("Вы зарегестрированы!");
                            }
                            catch
                            {
                                main.bd.User.Remove(user);
                                MessageBox.Show("Пользователь с таким логином уже существует");
                            }
                        }
                        else
                            MessageBox.Show("Должен быть один из этих знаков: *&{}|+.");
                    }
                    else
                        MessageBox.Show("Должна быть хотя бы одна цифра");
                }
                else
                    MessageBox.Show("Три одинаковы символатподряд повторяться не могут");
            }
            else
                MessageBox.Show("Пароль должен быть от 6 до 18 символов");
        }
    }
}
