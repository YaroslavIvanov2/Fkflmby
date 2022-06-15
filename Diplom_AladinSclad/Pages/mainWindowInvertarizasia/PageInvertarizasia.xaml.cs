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

namespace Diplom_AladinSclad.Pages.mainWindowInvertarizasia
{
    /// <summary>
    /// Логика взаимодействия для PageInvertarizasia.xaml
    /// </summary>
    public partial class PageInvertarizasia : Page
    {
        public PageInvertarizasia()
        {
            InitializeComponent();
        }
        public void Update()
        {
            var spisok = DataBase.GetContext().Inventarizacia.ToList();
            if (sortBox.IsChecked == true)
            {
                if (UpRadio.IsChecked == true)
                    spisok = spisok.OrderBy(p => p.Date).ToList();
                if (DownRadio.IsChecked == true)
                    spisok = spisok.OrderByDescending(p => p.Date).ToList();
            }
            userTabel.ItemsSource = spisok.ToList();
        }

        private void userTabel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void AddInvent_Click(object sender, RoutedEventArgs e)
        {
            WindowAddInvenorizasia windowAdd = new WindowAddInvenorizasia(this.Update);
            windowAdd.Show();
        }

        private void DeleteInvent_Click(object sender, RoutedEventArgs e)
        {
            if (userTabel.SelectedItems.Count != 0) // проверка, выделен ли элемент в списке
            {
                List<Inventarizacia> pM05Books = userTabel.SelectedItems.OfType<Inventarizacia>().ToList();
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataBase.GetContext().Inventarizacia.RemoveRange(pM05Books);
                    DataBase.GetContext().SaveChanges();
                    DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    Update();
                }
            }
        }

        private void sortBox_Checked(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void sortBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void DownRadio_Checked(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
