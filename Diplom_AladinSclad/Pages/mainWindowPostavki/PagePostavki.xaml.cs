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

namespace Diplom_AladinSclad.Pages.mainWindowPostavki
{
    /// <summary>
    /// Логика взаимодействия для PagePostavki.xaml
    /// </summary>
    public partial class PagePostavki : Page
    {
        public PagePostavki()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            var spisok = DataBase.GetContext().Postavki.ToList();
            spisokPostavok.ItemsSource = spisok;
        }

        private void AddTovar_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPostavka windowAdd = new WindowAddPostavka(this.Update);
            windowAdd.Show();
        }

        private void RedacTovar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeletePostav_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
