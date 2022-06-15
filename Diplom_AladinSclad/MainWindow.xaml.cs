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
using Diplom_AladinSclad.DB;

namespace Diplom_AladinSclad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sotrudnik admin;
        public MainWindow()
        {
            InitializeComponent();
            admin = new Sotrudnik();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            admin.Login = logintextbox.Text;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            admin.Password = passwordtextbox.Password;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(logintextbox.Text) || String.IsNullOrEmpty(passwordtextbox.Password))
            {
                MessageBox.Show("Введите данные во все поля");
                return;
            }
            if (DataBase.GetContext().Sotrudnik.Where(p => p.Login == admin.Login && p.Password == admin.Password).ToList().Count != 1)
            {
                MessageBox.Show("Введены не правильно данные");
                return;
            }
            admin = DataBase.GetContext().Sotrudnik.Where(p => p.Login == admin.Login && p.Password == admin.Password).ToList().First();
            WindowGlavnoeMenu mainWindow = new WindowGlavnoeMenu(admin);
            mainWindow.Owner = this;
            mainWindow.Show();
            this.Hide();

        }
    }
}
