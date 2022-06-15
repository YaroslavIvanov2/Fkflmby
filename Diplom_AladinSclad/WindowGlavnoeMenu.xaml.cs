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
using System.Windows.Shapes;
using Diplom_AladinSclad.DB;
using Diplom_AladinSclad.View;

namespace Diplom_AladinSclad
{
    /// <summary>
    /// Логика взаимодействия для WindowGlavnoeMenu.xaml
    /// </summary>
    public partial class WindowGlavnoeMenu : Window
    {
        public WindowGlavnoeMenu(Sotrudnik admins)
        {
            InitializeComponent();
            DataContext = new MainViewModel(admins);
        }
        private void Exit_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
