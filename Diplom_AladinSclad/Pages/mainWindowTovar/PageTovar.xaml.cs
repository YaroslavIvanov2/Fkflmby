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
using Diplom_AladinSclad.View;

namespace Diplom_AladinSclad.Pages.mainWindowTovar
{
    /// <summary>
    /// Логика взаимодействия для PageTovar.xaml
    /// </summary>
    public partial class PageTovar : Page
    {
        CatalogTovarovViewModel catalog;
        public PageTovar()
        {
            InitializeComponent();
            catalog = new CatalogTovarovViewModel();
            DataContext = catalog;
            Update();
        }
        public void Update()
        {
            /*var spisok = DataBase.GetContext().Tovar.ToList();
            if (!String.IsNullOrWhiteSpace(SearchBox.Text))
            {
                spisok = spisok.Where(p => p.Naimenovanie_tovara.Contains(SearchBox.Text)).ToList();
            }
            userTabel.ItemsSource = spisok;*/
            catalog.UpdateDishesList();
        }
        private void RedacTovar_Click(object sender, RoutedEventArgs e)
        {
            if (userTabel.SelectedItem != null)
            {
                WindowAddTovar windowAdd = new WindowAddTovar(userTabel.SelectedItem as Tovar);
                windowAdd.Show();
            }
        }

        private void AddTovar_Click(object sender, RoutedEventArgs e)
        {
            WindowAddTovar windowAdd = new WindowAddTovar(this.Update);
            windowAdd.Show();
        }

        private void DeleteTovar_Click(object sender, RoutedEventArgs e)
        {
            if (userTabel.SelectedItems.Count != 0) // проверка, выделен ли элемент в списке
            {
                List<Tovar> pM05Books = userTabel.SelectedItems.OfType<Tovar>().ToList();
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хоите удалить?", "Удаление", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataBase.GetContext().Tovar.RemoveRange(pM05Books);
                    DataBase.GetContext().SaveChanges();
                    DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    
                }
            }
        }

       

        private void CheckBox_Checked(object sender, RoutedEventArgs e) => catalog.UpdateDishesList();
        

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            catalog.UpdateDishesList();
        }
    }
}
